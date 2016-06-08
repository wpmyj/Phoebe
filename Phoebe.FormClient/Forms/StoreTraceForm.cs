﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    /// 库存追溯窗体
    /// </summary>
    public partial class StoreTraceForm : BaseForm
    {
        #region Field
        /// <summary>
        /// 分类列表，缓存页面使用
        /// </summary>
        private List<Category> categoryList;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 库存追溯窗体
        /// </summary>
        public StoreTraceForm()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 更新合同选择
        /// </summary>
        /// <param name="customerId">客户Id</param>
        private void UpdateContractList(int customerId)
        {
            var contracts = BusinessFactory<ContractBusiness>.Instance.GetByCustomer(customerId);

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

            this.sfgList.Clear();
            this.sgList.Clear();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoreTraceForm_Load(object sender, EventArgs e)
        {
            this.categoryList = BusinessFactory<CategoryBusiness>.Instance.GetLeafCategory();
            this.clcCategory.SetDataSource(categoryList);
             
            this.bsCustomer.DataSource = BusinessFactory<CustomerBusiness>.Instance.FindAll();
            this.lkuCustomer.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(EventUtil.LkuCustomer_CustomDisplayText);
        }

        /// <summary>
        /// 选择客户
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
        /// 搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.lkuCustomer.EditValue == null)
            {
                MessageUtil.ShowClaim("请选择客户");
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            EntityStatus storeStatus = EntityStatus.StoreIn;
            if (rbStoreIn.Checked)
                storeStatus = EntityStatus.StoreIn;
            else
                storeStatus = EntityStatus.StoreOut;

            int customerId = Convert.ToInt32(this.lkuCustomer.EditValue);

            List<Store> data = new List<Store>();
            data = BusinessFactory<StoreBusiness>.Instance.GetByCustomer(customerId, storeStatus);

            // filter contract
            if (this.cmbContract.EditValue != null)
            {
                int contractId = Convert.ToInt32(this.cmbContract.EditValue);
                data = data.Where(r => r.Cargo.ContractId == contractId).ToList();
            }

            // filter category
            var category = this.categoryList.SingleOrDefault(r => r.Number == this.txtCategoryNumber.Text);
            if (category != null)
            {
                var parent = BusinessFactory<CategoryBusiness>.Instance.GetByParent(this.txtCategoryNumber.Text);
                if (parent != null)
                {
                    data = data.Where(r => parent.Select(s => s.Id).Contains(r.Cargo.CategoryId)).ToList();
                }
            }

            this.sgList.DataSource = data;

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// 追溯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrace_Click(object sender, EventArgs e)
        {
            var store = this.sgList.GetCurrentSelect();
            if (store == null)
            {
                MessageUtil.ShowClaim("未选择记录");
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            var flow = BusinessFactory<StoreBusiness>.Instance.GetStoreFlow(store.Id).OrderBy(r => r.FlowDate).ToList();
            this.sfgList.DataSource = flow;

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// 修正流水
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFix_Click(object sender, EventArgs e)
        {
            var store = this.sgList.GetCurrentSelect();
            if (store == null)
            {
                MessageUtil.ShowClaim("未选择记录");
                return;
            }

            ErrorCode result = BusinessFactory<StoreBusiness>.Instance.FixStore(store.Id);
            if (result == ErrorCode.Success)
            {
                var flow = BusinessFactory<StoreBusiness>.Instance.GetStoreFlow(store.Id).OrderBy(r => r.FlowDate).ToList();
                this.sfgList.DataSource = flow;

                MessageUtil.ShowInfo("流水修正成功");
            }
            else
            {
                MessageUtil.ShowWarning("流水修正失败：" + result.DisplayName());
            }
        }
        #endregion //Event
    }
}
