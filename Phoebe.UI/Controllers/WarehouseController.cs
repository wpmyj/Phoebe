﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Phoebe.Business;
using Phoebe.Common;
using Phoebe.Model;

namespace Phoebe.UI.Controllers
{
    /// <summary>
    /// 仓库控制器
    /// </summary>
    public class WarehouseController : Controller
    {
        #region Field
        /// <summary>
        /// 仓库业务
        /// </summary>
        private WarehouseBusiness warehouseBusiness;
        #endregion //Field

        #region Constructor
        public WarehouseController()
        {
            this.warehouseBusiness = new WarehouseBusiness();
        }
        #endregion //Constructor

        #region Action
        /// <summary>
        /// 仓库主页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var data = this.warehouseBusiness.Get();
            return View(data);
        }

        /// <summary>
        /// 仓库信息
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ActionResult Info(int id)
        {
            var data = this.warehouseBusiness.Get(id);
            return View(data);
        }

        /// <summary>
        /// 编辑仓库
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = this.warehouseBusiness.Get(id);
            if (data == null)
                return HttpNotFound();

            return View(data);
        }

        /// <summary>
        /// 编辑仓库
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Warehouse model)
        {
            if (ModelState.IsValid)
            {
                var data = this.warehouseBusiness.Get(model.ID);

                data.Remark = model.Remark;
                ErrorCode result = this.warehouseBusiness.Save();

                if (result == ErrorCode.Success)
                {
                    TempData["Message"] = "编辑仓库成功";
                    return RedirectToAction("Index", "Warehouse");
                }
                else
                {
                    TempData["Message"] = "编辑仓库失败";
                    ModelState.AddModelError("", "添加部门失败: " + result.DisplayName());
                }
            }

            return View(model);
        }
        #endregion //Action
    }
}