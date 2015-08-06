﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phoebe.Model;

namespace Phoebe.Business
{
    /// <summary>
    /// 仓库业务类
    /// </summary>
    public class WarehouseBusiness
    {
        #region Field
        private PhoebeContext context;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 仓库业务类
        /// </summary>
        public WarehouseBusiness()
        {
            this.context = new PhoebeContext();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有仓库
        /// </summary>
        /// <returns></returns>
        public List<Warehouse> Get()
        {
            return this.context.Warehouses.ToList();
        }

        /// <summary>
        /// 获取仓库
        /// </summary>
        /// <param name="id">仓库ID</param>
        /// <returns></returns>
        public Warehouse Get(int id)
        {
            return this.context.Warehouses.SingleOrDefault(r => r.ID == id);
        }

        /// <summary>
        /// 获取顶级仓库
        /// </summary>
        /// <returns></returns>
        public Warehouse GetTop()
        {
            return this.context.Warehouses.FirstOrDefault(r => r.Hierarchy == 1);
        }
        #endregion //Method
    }
}
