﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phoebe.FormClient
{
    using DevExpress.XtraEditors.Controls;
    using Phoebe.Base;
    using Phoebe.Business;
    using Phoebe.Common;
    using Phoebe.Model;

    /// <summary>
    /// 移库添加控件
    /// </summary>
    public partial class StockMoveAddControl : UserControl
    {
        #region Field
        /// <summary>
        /// 登录用户
        /// </summary>
        private LoginUser currentUser;

        /// <summary>
        /// 选中合同
        /// </summary>
        private Contract selectContract;

        /// <summary>
        /// 货品是否等重
        /// </summary>
        private bool isEqualWeight = true;

        /// <summary>
        /// 分类列表，缓存页面使用
        /// </summary>
        private List<Category> categoryList;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 移库添加控件
        /// </summary>
        /// <param name="user"></param>
        public StockMoveAddControl(LoginUser user)
        {
            InitializeComponent();

            this.currentUser = user;

            this.txtStatus.Text = "新建移库";
            this.txtUser.Text = this.currentUser.Name;
            this.dpMoveTime.DateTime = DateTime.Now.Date;

            this.bsCustomer.DataSource = BusinessFactory<CustomerBusiness>.Instance.FindAll();
            this.lkuCustomer.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(EventUtil.LkuCustomer_CustomDisplayText);

            this.categoryList = BusinessFactory<CategoryBusiness>.Instance.GetLeafCategory();
            this.clcCategory.SetDataSource(this.categoryList);

            this.smgList.DataSource = new List<StockMoveModel>();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 更新合同选择
        /// </summary>
        /// <param name="customerId">客户Id</param>
        private void UpdateContractList(int customerId)
        {
            var contracts = BusinessFactory<ContractBusiness>.Instance.GetByCustomer2(customerId);

            this.cmbContract.Properties.Items.Clear();
            foreach (var item in contracts)
            {
                ImageComboBoxItem i = new ImageComboBoxItem();
                i.Description = item.Name;
                i.Value = item.Id;

                this.cmbContract.Properties.Items.Add(i);
            }

            if (contracts.Count > 0)
                this.cmbContract.EditValue = contracts[0].Id;
            else
                this.cmbContract.EditValue = null;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 保存移库
        /// </summary>
        /// <param name="errorMessage">错误消息</param>
        /// <param name="newId">新移库单ID</param>
        /// <param name="month">月份</param>
        /// <returns></returns>
        public ErrorCode Save(out string errorMessage, out Guid newId, out string month)
        {
            errorMessage = "";
            month = "";
            newId = Guid.Empty;
            this.smgList.CloseEditor();

            // check input data and format digit
            if (this.lkuCustomer.EditValue == null)
            {
                errorMessage = "请选择客户";
                return ErrorCode.Error;
            }
            if (this.selectContract == null)
            {
                errorMessage = "请选择合同";
                return ErrorCode.Error;
            }
            if (this.smgList.DataSource.Count == 0)
            {
                errorMessage = "没有移库货品";
                return ErrorCode.Error;
            }

            foreach (var item in this.smgList.DataSource)
            {
                if (item.MoveCount < 0)
                {
                    errorMessage = "移库数量不能为负数";
                    return ErrorCode.Error;
                }
                if (item.MoveCount > item.StoreCount)
                {
                    errorMessage = "移库数量大于在库数量";
                    return ErrorCode.Error;
                }
                if (item.MoveTime > this.dpMoveTime.DateTime.Date)
                {
                    errorMessage = "移库时间早于货品移入时间";
                    return ErrorCode.Error;
                }
                if (string.IsNullOrEmpty(item.NewWarehouseNumber))
                {
                    errorMessage = "新仓位编号不能为空";
                    return ErrorCode.Error;
                }

                item.MoveWeight = Math.Round(item.MoveWeight, 4);
                item.MoveVolume = Math.Round(item.MoveVolume, 4);
            }

            // set stock move
            StockMove sm = new StockMove();
            sm.Id = Guid.NewGuid();
            sm.MoveTime = this.dpMoveTime.DateTime.Date;
            sm.MonthTime = sm.MoveTime.Year.ToString() + sm.MoveTime.Month.ToString().PadLeft(2, '0');
            sm.ContractId = this.selectContract.Id;
            sm.UserId = this.currentUser.Id;
            sm.CreateTime = DateTime.Now;
            sm.Remark = this.txtRemark.Text;

            // add stock move
            ErrorCode result = BusinessFactory<StockMoveBusiness>.Instance.Create(sm, this.smgList.DataSource);
            if (result == ErrorCode.Success)
            {
                newId = sm.Id;
                month = sm.MonthTime;
            }

            return result;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 客户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lkuCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lkuCustomer.EditValue == null)
                UpdateContractList(0);
            else
                UpdateContractList(Convert.ToInt32(this.lkuCustomer.EditValue));
        }

        /// <summary>
        /// 选择合同
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbContract_EditValueChanged(object sender, EventArgs e)
        {
            if (this.cmbContract.EditValue == null)
            {
                this.selectContract = null;
                this.txtBillingType.Text = "";
            }
            else
            {
                int contractId = Convert.ToInt32(this.cmbContract.EditValue);
                this.selectContract = BusinessFactory<ContractBusiness>.Instance.FindById(contractId);

                if ((BillingType)this.selectContract.BillingType == BillingType.VariousWeight)
                    this.isEqualWeight = false;
                else
                    this.isEqualWeight = true;

                this.smgList.SetEqualWeight(this.isEqualWeight);
                this.txtBillingType.Text = ((BillingType)this.selectContract.BillingType).DisplayName();
            }

            this.smgFilter.Clear();
            this.smgList.Clear();
        }

        /// <summary>
        /// 分类代码输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCategoryNumber_EditValueChanged(object sender, EventArgs e)
        {
            string number = this.txtCategoryNumber.EditValue.ToString();
            this.clcCategory.UpdateView(number);

            var category = this.categoryList.SingleOrDefault(r => r.Number == number);
            if (category != null)
            {
                this.txtCategoryName.Text = category.Name;
            }
            else
            {
                this.txtCategoryName.Text = "";
            }
        }

        /// <summary>
        /// 选择分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clcCategory_CategoryItemSelected(object sender, EventArgs e)
        {
            this.txtCategoryNumber.EditValueChanged -= txtCategoryNumber_EditValueChanged;

            this.txtCategoryNumber.Text = this.clcCategory.SelectedNumber;
            this.txtCategoryName.Text = this.clcCategory.SelectedName;

            this.txtCategoryNumber.EditValueChanged += txtCategoryNumber_EditValueChanged;
        }

        /// <summary>
        /// 搜索库存记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.selectContract == null)
            {
                MessageUtil.ShowClaim("未选择合同");
                return;
            }

            var stores = BusinessFactory<StoreBusiness>.Instance.GetByContract(this.selectContract.Id, true);
            var category = BusinessFactory<CategoryBusiness>.Instance.GetByParent(this.txtCategoryNumber.Text);
            if (category != null)
            {
                stores = stores.Where(r => category.Select(s => s.Id).Contains(r.Cargo.CategoryId)).ToList();
            }

            var data = ModelTranslate.StoreToStockMove(stores);
            this.smgFilter.DataSource = data;
        }

        /// <summary>
        /// 加入移库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTo_Click(object sender, EventArgs e)
        {
            if (this.selectContract == null)
            {
                MessageUtil.ShowClaim("未选择合同");
                return;
            }

            var select = this.smgFilter.GetCurrentSelect();
            if (select == null)
            {
                MessageUtil.ShowClaim("未选择记录");
                return;
            }
            else
            {
                if (this.smgList.CheckHasStore(select))
                {
                    MessageUtil.ShowClaim("该货品已经加入");
                    return;
                }

                int count = Convert.ToInt32(this.nmMoveCount.Value);
                if (count > select.StoreCount)
                {
                    MessageUtil.ShowClaim("移库数量大于在库数量");
                    return;
                }

                select.MoveCount = count;
                if (this.isEqualWeight)
                {
                    select.MoveWeight = count * select.UnitWeight / 1000;
                }
                select.MoveVolume = count * select.UnitVolume;
                select.NewWarehouseNumber = this.txtNewWarehouse.Text;

                this.smgList.DataSource.Add(select);
                this.smgList.UpdateBindingData();
            }
        }

        /// <summary>
        /// 删除移库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveFrom_Click(object sender, EventArgs e)
        {
            var select = this.smgList.GetCurrentSelect();
            if (select == null)
            {
                MessageUtil.ShowClaim("未选择记录");
                return;
            }
            else
            {
                this.smgList.DataSource.Remove(select);
                this.smgList.UpdateBindingData();
            }
        }
        #endregion //Event
    }
}
