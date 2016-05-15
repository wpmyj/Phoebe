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
    /// 出库业务类
    /// </summary>
    public class StockOutBusiness : BaseBusiness<StockOut>
    {
        #region Field
        /// <summary>
        /// 数据访问接口
        /// </summary>
        private IBaseDataAccess<StockOut> dal;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 出库业务类
        /// </summary>
        public StockOutBusiness() : base()
        {
            this.dal = new StockOutRepository();
            base.Init(this.dal);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 获取最新流水单号
        /// </summary>
        /// <param name="outTime">出库时间</param>
        /// <returns></returns>
        private string GetLastFlowNumber(DateTime outTime)
        {
            Expression<Func<StockOut, bool>> predicate = r => r.OutTime == outTime;
            var data = this.dal.Find(predicate).OrderByDescending(r => r.FlowNumber);

            if (data.Count() == 0)
                return string.Format("{0}{1}{2}0001",
                    outTime.Year, outTime.Month.ToString().PadLeft(2, '0'), outTime.Day.ToString().PadLeft(2, '0'));
            else
            {
                int newNumber = Convert.ToInt32(data.First().FlowNumber.Substring(8)) + 1;
                return string.Format("{0}{1}{2}{3}", outTime.Year, outTime.Month.ToString().PadLeft(2, '0'),
                    outTime.Day.ToString().PadLeft(2, '0'), newNumber.ToString().PadLeft(4, '0'));
            }
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 创建出库单
        /// </summary>
        /// <param name="entity">出库单对象</param>
        /// <param name="models">出库信息模型</param>
        /// <returns></returns>
        public ErrorCode Create(StockOut entity, List<StockOutModel> models)
        {
            try
            {
                // set stock in
                entity.FlowNumber = GetLastFlowNumber(entity.OutTime.Date);
                entity.Status = (int)EntityStatus.StockOutReady;

                // generate stock out details
                List<StockOutDetail> details = new List<StockOutDetail>();
                foreach (var item in models)
                {
                    StockOutDetail detail = new StockOutDetail();
                    detail.Id = Guid.NewGuid();
                    detail.StockOutId = entity.Id;
                    detail.StoreId = item.StoreId;
                    detail.StoreCount = item.StoreCount;
                    detail.Count = item.OutCount;
                    detail.OutWeight = item.OutWeight;
                    detail.OutVolume = item.OutVolume;
                    detail.Remark = item.Remark;
                    detail.Status = (int)EntityStatus.StockOutReady;

                    details.Add(detail);
                }

                var trans = new TransactionRepository();
                ErrorCode result = trans.StockOutAddTrans(entity, details);

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
