﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Phoebe.Base
{
    public enum ErrorCode
    {
        #region System
        /// <summary>
        /// 成功
        /// </summary>
        [Display(Name = "成功")]
        Success = 0,

        /// <summary>
        /// 错误
        /// </summary>
        [Display(Name = "错误")]
        Error = 1,

        /// <summary>
        /// 异常
        /// </summary>
        [Display(Name = "异常")]
        Exception = 2,

        /// <summary>
        /// 未实现程序
        /// </summary>
        [Display(Name = "未实现程序")]
        NotImplement = 3,

        /// <summary>
        /// 对象已删除
        /// </summary>
        [Display(Name = "对象已删除")]
        ObjectDeleted = 4,

        /// <summary>
        /// 对象未找到
        /// </summary>
        [Display(Name = "对象未找到")]
        ObjectNotFound = 5,

        /// <summary>
        /// 数据库写入失败
        /// </summary>
        [Display(Name = "数据库写入失败")]
        DatabaseWriteError = 6,

        /// <summary>
        /// 权限不够
        /// </summary>
        [Display(Name = "权限不够")]
        NoPrivilege = 7,

        /// <summary>
        /// 名称为空
        /// </summary>
        [Display(Name = "名称为空")]
        EmptyName = 8,

        /// <summary>
        /// 名称重复
        /// </summary>
        [Display(Name = "名称重复")]
        DuplicateName = 9,

        /// <summary>
        /// 编号重复
        /// </summary>
        [Display(Name = "编号重复")]
        DuplicateNumber = 10,

        /// <summary>
        /// 未选择记录
        /// </summary>
        [Display(Name = "未选择记录")]
        EmptySelect = 11,
        #endregion //System

        #region User
        /// <summary>
        /// 密码错误
        /// </summary>
        [Display(Name = "密码错误")]
        WrongPassword = 21,

        /// <summary>
        /// 用户不存在
        /// </summary>
        [Display(Name = "用户不存在")]
        UserNotExist = 22,

        /// <summary>
        /// 用户已禁用
        /// </summary>
        [Display(Name = "用户已禁用")]
        UserDisabled = 23,

        /// <summary>
        /// 用户无法创建
        /// </summary>
        [Display(Name = "用户无法创建")]
        UserCannotCreate = 24,
        #endregion //User

        #region Customer
        /// <summary>
        /// 客户有合同
        /// </summary>
        [Display(Name = "客户有合同")]
        CustomerHasContract = 30,

        /// <summary>
        /// 客户有结算
        /// </summary>
        [Display(Name = "客户有结算")]
        CustomerHasSettlement = 31,

        /// <summary>
        /// 客户有缴费
        /// </summary>
        [Display(Name = "客户有缴费")]
        CustomerHasPayment = 32,
        #endregion //Customer

        #region Contract
        /// <summary>
        /// 合同有库存
        /// </summary>
        [Display(Name = "合同有库存")]
        ContractHasStore = 40,

        /// <summary>
        /// 合同有货品
        /// </summary>
        [Display(Name = "合同有货品")]
        ContractHasCargo = 41,
        #endregion //Contract

        #region Cargo
        /// <summary>
        /// 货品创建失败
        /// </summary>
        [Display(Name = "货品创建失败")]
        CargoCreateFailed = 50,

        /// <summary>
        /// 货品已存在
        /// </summary>
        [Display(Name = "货品已存在")]
        CargoExist = 51,

        /// <summary>
        /// 分类含有下级
        /// </summary>
        [Display(Name = "分类含有下级")]
        CategoryHasChild = 52,

        /// <summary>
        /// 分类含有货品
        /// </summary>
        [Display(Name = "分类含有货品")]
        CategoryHasCargo = 53,
        #endregion //Cargo

        #region Store

        #endregion //Store

        #region Stock
        /// <summary>
        /// 入库记录无法删除
        /// </summary>
        [Display(Name = "入库记录无法删除")]
        StockInCannotDelete = 70,

        /// <summary>
        /// 入库已确认
        /// </summary>
        [Display(Name = "入库已确认")]
        StockInHasConfirm = 71,

        /// <summary>
        /// 入库记录无法撤回
        /// </summary>
        [Display(Name = "入库记录无法撤回")]
        StockInCannotRevert = 72,

        /// <summary>
        /// 出库记录无法删除
        /// </summary>
        [Display(Name = "出库记录无法删除")]
        StockOutCannotDelete = 80,

        /// <summary>
        /// 出库已确认
        /// </summary>
        [Display(Name = "出库已确认")]
        StockOutHasConfirm = 81,

        /// <summary>
        /// 出库数量超出
        /// </summary>
        [Display(Name = "出库数量超出")]
        StockOutCountOverflow = 82,

        /// <summary>
        /// 出库记录无法撤回
        /// </summary>
        [Display(Name = "出库记录无法撤回")]
        StockOutCannotRevert = 83,

        /// <summary>
        /// 移库记录无法删除
        /// </summary>
        [Display(Name = "移库记录无法删除")]
        StockMoveCannotDelete = 90,

        /// <summary>
        /// 移库已确认
        /// </summary>
        [Display(Name = "移库已确认")]
        StockMoveHasConfirm = 91,

        /// <summary>
        /// 移库数量超出
        /// </summary>
        [Display(Name = "移库数量超出")]
        StockMoveCountOverflow = 92,

        /// <summary>
        /// 移库记录无法撤回
        /// </summary>
        [Display(Name = "移库记录无法撤回")]
        StockMoveCannotRevert = 93,
        #endregion //Stock

        #region Ice
        /// <summary>
        /// 冰块出库数量超出
        /// </summary>
        [Display(Name = "冰块出库数量超出")]
        IceOutCountOverflow = 100,

        /// <summary>
        /// 冰块出库重量超出
        /// </summary>
        [Display(Name = "冰块出库重量超出")]
        IceOutWeightOverflow = 101,

        /// <summary>
        /// 冰块删除数量超出
        /// </summary>
        [Display(Name = "冰块删除数量超出")]
        IceDeleteCountOverflow = 102,

        /// <summary>
        /// 冰块删除重量超出
        /// </summary>
        [Display(Name = "冰块删除重量超出")]
        IceDeleteWeightOverflow = 103,
        #endregion //Ice
    }
}
