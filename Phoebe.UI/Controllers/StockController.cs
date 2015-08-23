﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Phoebe.Business;
using Phoebe.Common;
using Phoebe.Model;
using Phoebe.UI.Filters;
using Phoebe.UI.Services;

namespace Phoebe.UI.Controllers
{
    /// <summary>
    /// 库存控制器
    /// </summary>
    public class StockController : Controller
    {
        #region Field
        /// <summary>
        /// 仓储业务
        /// </summary>
        private StoreBusiness storeBusiness;
        #endregion //Field

        #region Constructor
        public StockController()
        {
            this.storeBusiness = new StoreBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 库存记录
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.storeBusiness.GetStock();
            return View(data);
        }
        #endregion //Action

        #region Json
        public JsonResult GetStockCargo(int trayId)
        {
            return null;
        }
        #endregion //Json
    }
}