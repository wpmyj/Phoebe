﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Phoebe.Business
{
    using Phoebe.Base;
    using Phoebe.Model;
    using Phoebe.Business.DAL;

    /// <summary>
    /// 入库业务类
    /// </summary>
    public class StockInBusiness : BaseBusiness<StockIn>
    {
        #region Field
        /// <summary>
        /// 数据访问接口
        /// </summary>
        private IBaseDataAccess<StockIn> dal;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 客户业务类
        /// </summary>
        public StockInBusiness() : base()
        {
            this.dal = new StockInRepository();
            base.Init(this.dal);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 获取最新流水单号
        /// </summary>
        /// <param name="inTime">入库时间</param>
        /// <returns></returns>
        private string GetLastStockInFlowNumber(DateTime inTime)
        {
            Expression<Func<StockIn, bool>> predicate = r => r.InTime == inTime;
            var data = this.dal.Find(predicate).OrderByDescending(r => r.FlowNumber);

            if (data.Count() == 0)
                return string.Format("{0}{1}{2}0001",
                    inTime.Year, inTime.Month.ToString().PadLeft(2, '0'), inTime.Day.ToString().PadLeft(2, '0'));
            else
            {
                int newNumber = Convert.ToInt32(data.First().FlowNumber.Substring(8)) + 1;
                return string.Format("{0}{1}{2}{3}", inTime.Year, inTime.Month.ToString().PadLeft(2, '0'),
                    inTime.Day.ToString().PadLeft(2, '0'), newNumber.ToString().PadLeft(4, '0'));
            }
        }
        #endregion //Function

        #region Method
        [Obsolete]
        public override ErrorCode Create(StockIn entity)
        {
            return ErrorCode.NotImplement;
        }

        /// <summary>
        /// 创建入库单
        /// </summary>
        /// <param name="entity">入库对象</param>
        /// <param name="models">入库记录</param>
        /// <returns></returns>
        public ErrorCode Create(StockIn entity, List<StockInModel> models)
        {
            try
            {
                // set stock in
                entity.Id = Guid.NewGuid();
                entity.FlowNumber = GetLastStockInFlowNumber(entity.InTime.Date);
                entity.Status = (int)EntityStatus.StockInReady;

                // generate stock in details
                List<StockInDetail> details = new List<StockInDetail>();
                foreach (var item in models)
                {
                    StockInDetail detail = new StockInDetail();
                    detail.Id = Guid.NewGuid();
                    detail.StockInId = entity.Id;
                    detail.Count = item.InCount;
                    detail.InWeight = item.InWeight;
                    detail.InVolume = item.InVolume;
                    detail.Remark = item.Remark;
                    detail.Status = (int)EntityStatus.StockInReady;

                    details.Add(detail);
                }

                // set store
                List<Store> storeList = new List<Store>();
                foreach (var item in models)
                {
                    Store store = new Store();
                    store.Id = Guid.NewGuid();
                    store.CargoId = item.CargoId;
                    store.WarehouseNumber = item.WarehouseNumber;
                    store.TotalCount = item.InCount;
                    store.StoreCount = store.TotalCount;
                    store.TotalWeight = item.InWeight;
                    store.StoreWeight = store.TotalWeight;
                    store.TotalVolume = item.InVolume;
                    store.StoreVolume = store.TotalVolume;
                    store.InTime = entity.InTime;
                    store.MoveTime = entity.InTime;
                    store.Specification = item.Specification;
                    store.OriginPlace = item.OriginPlace;
                    store.ShelfLife = item.ShelfLife;
                    store.Source = (int)SourceType.StockIn;
                    store.UserId = entity.UserId;
                    store.Status = (int)EntityStatus.StoreReady;

                    storeList.Add(store);
                }

                var trans = new TransactionRepository();
                ErrorCode result = trans.StockInTrans(entity, details, storeList);

                return result;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }
        #endregion //Method
    }
}