﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phoebe.Model;

namespace Phoebe.Business
{
    /// <summary>
    /// 计数计费
    /// </summary>
    public class BillingCount : IBillingProcess
    {
        #region Method
        /// <summary>
        /// 获取单位计量
        /// </summary>
        /// <param name="cargo">货品</param>
        /// <returns></returns>
        public decimal GetUnitMeter(Cargo cargo)
        {
            return 1;
        }

        /// <summary>
        /// 获取出入库数量
        /// </summary>
        /// <param name="flow">流水记录</param>
        /// <returns></returns>
        public decimal GetFlowMeter(StockFlow flow)
        {
            if (flow.Type == StockFlowType.StockOut || flow.Type == StockFlowType.StockMoveOut)
                return -flow.Count;
            else
                return flow.Count;
        }

        /// <summary>
        /// 获取在库数量
        /// </summary>
        /// <param name="storage">库存记录</param>
        /// <returns></returns>
        public decimal GetStoreMeter(Storage storage)
        {
            return storage.Count;
        }

        /// <summary>
        /// 计算日冷藏费
        /// </summary>
        /// <param name="totalMeter">总数量</param>
        /// <param name="unitPrice">单价</param>
        /// <returns></returns>
        public decimal CalculateDailyFee(decimal totalMeter, decimal unitPrice)
        {
            return totalMeter * unitPrice;
        }
        #endregion //Method
    }
}