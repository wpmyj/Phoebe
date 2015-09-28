﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phoebe.Model;

namespace Phoebe.Business
{
    /// <summary>
    /// 结算业务类
    /// </summary>
    public class SettleBusiness
    {
        #region Field
        private PhoebeContext context;
        #endregion //Field

        #region Constructor
        public SettleBusiness()
        {
            this.context = new PhoebeContext();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取结算列表
        /// </summary>
        /// <param name="status">状态</param>
        /// <returns></returns>
        public List<Settlement> Get(EntityStatus status)
        {
            return this.context.Settlements.Where(r => r.Status == (int)status).ToList();
        }

        /// <summary>
        /// 获取结算信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Settlement Get(string id)
        {
            Guid gid;
            if (!Guid.TryParse(id, out gid))
                return null;

            return this.context.Settlements.Find(gid);
        }

        /// <summary>
        /// 添加结算
        /// </summary>
        /// <param name="data">结算数据</param>
        /// <returns></returns>
        public ErrorCode Create(Settlement data)
        {
            try
            {
                Cargo cargo = this.context.Cargoes.Find(data.CargoID);
                if (cargo == null)
                    return ErrorCode.CargoNotFound;
                if (cargo.Status != (int)EntityStatus.CargoStockOut)
                    return ErrorCode.CargoCannotSettled;

                int count = this.context.Settlements.Count(r => r.Number == data.Number);
                if (count > 0)
                    return ErrorCode.DuplicateNumber;

                data.WeightTotalPrice = data.Weight * data.WeightUnitPrice;
                data.VolumeTotalPrice = data.Volume * data.VolumeUnitPrice;

                data.TotalPrice = (data.WeightTotalPrice + data.VolumeTotalPrice) * data.Discount / 100 - data.Remission;
                data.SettleTime = DateTime.Now;
                data.Status = (int)EntityStatus.SettleUnpaid;

                // edit cargo status
                cargo.Status = (int)EntityStatus.CargoSettled;

                this.context.Settlements.Add(data);
                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 结算审核
        /// </summary>
        /// <param name="id">结算ID</param>
        /// <param name="paid">付款金额</param>
        /// <param name="remark">备注</param>
        /// <returns></returns>
        public ErrorCode Audit(string id, decimal paid, string remark)
        {
            try
            {
                Guid gid;
                if (!Guid.TryParse(id, out gid))
                    return ErrorCode.ObjectNotFound;

                Settlement settle = this.context.Settlements.Find(gid);
                settle.PaidPrice = paid;
                settle.ConfirmTime = DateTime.Now;
                settle.Remark = remark;
                settle.Status = (int)EntityStatus.SettlePaid;

                settle.Cargo.Status = (int)EntityStatus.CargoPaid;

                this.context.SaveChanges();
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 冷藏费计算
        /// </summary>
        /// <param name="contractID">合同ID</param>
        /// <param name="start">开始日期</param>
        /// <param name="end">结束日期</param>
        /// <param name="dailyFee">冷藏费单价</param>
        /// <returns></returns>
        public List<ChargeRecord> Process(int contractID, DateTime start, DateTime end, double dailyFee)
        {
            //var cargos = this.context.Cargoes.Where(r => r.ContractID == contractID && (r.OutTime == null || (r.OutTime >= start && r.OutTime <= end)));
            var cargos = this.context.Cargoes.Where(r => r.ContractID == contractID);

            var stockIns = from r in this.context.StockIns
                           where r.Status == (int)EntityStatus.StockIn && r.ConfirmTime >= start && r.ConfirmTime <= end &&
                                cargos.Select(s => s.ID).Contains(r.CargoID)
                           select r;

            var stockOuts = from r in this.context.StockOuts
                            where r.Status == (int)EntityStatus.StockOut && r.ConfirmTime >= start && r.ConfirmTime <= end &&
                                cargos.Select(s => s.ID).Contains(r.CargoID)
                            select r;

            decimal totalWeight = 0;
            decimal totalFee = 0;

            List<ChargeRecord> records = new List<ChargeRecord>();
            for (DateTime step = start.Date; step <= end; step = step.AddDays(1))
            {
                var nextDay = step.AddDays(1);
                int todayCount = 0;

                //find stocks in day
                var ins = stockIns.Where(r => r.ConfirmTime >= step && r.ConfirmTime < nextDay);

                if (ins.Count() != 0)
                {
                    foreach (var item in ins)
                    {
                        ChargeRecord record = new ChargeRecord();
                        record.RecordDate = step;

                        var c = cargos.Single(r => r.ID == item.CargoID);

                        record.RecordDate = step;
                        record.CargoName = c.Name;
                        record.UnitWeight = c.UnitWeight.Value;
                        record.Count = c.Count;
                        record.StoreWeight = Convert.ToDecimal(c.TotalWeight.Value);
                        totalWeight += record.StoreWeight;
                        record.TotalWeight = totalWeight;

                        records.Add(record);
                        todayCount++;
                    }

                    var last = records.Last();
                    last.DailyFee = last.TotalWeight * (decimal)dailyFee;
                    totalFee += last.DailyFee;
                    last.TotalFee = totalFee;
                }

                var outs = stockOuts.Where(r => r.ConfirmTime >= step && r.ConfirmTime < nextDay);
                if (outs.Count() != 0)
                {
                    if (todayCount > 0)
                    {
                        var lastIn = records.Last();
                        totalFee -= lastIn.DailyFee;
                        lastIn.DailyFee = 0;
                        lastIn.TotalFee = 0;
                    }

                    foreach (var item in outs)
                    {
                        ChargeRecord record = new ChargeRecord();
                        record.RecordDate = step;

                        var c = cargos.Single(r => r.ID == item.CargoID);

                        record.RecordDate = step;
                        record.CargoName = c.Name;
                        record.UnitWeight = c.UnitWeight.Value;

                        record.Count = -item.StockOutDetails.Sum(r => r.Count);
                        record.StoreWeight = Convert.ToDecimal(record.UnitWeight * record.Count / 1000);
                        totalWeight += record.StoreWeight;
                        record.TotalWeight = totalWeight;

                        records.Add(record);
                        todayCount++;
                    }

                    var last = records.Last();
                    last.DailyFee = last.TotalWeight * (decimal)dailyFee;
                    totalFee += last.DailyFee;
                    last.TotalFee = totalFee;
                }

                if (todayCount == 0)
                {
                    ChargeRecord record = new ChargeRecord();
                    record.RecordDate = step;
                    record.TotalWeight = totalWeight;
                    record.DailyFee = record.TotalWeight * (decimal)dailyFee;
                    totalFee += record.DailyFee;
                    record.TotalFee = totalFee;

                    records.Add(record);
                }
            }

            return records;
        }
        #endregion //Method
    }
}
