﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phoebe.FormClient
{
    using Phoebe.Base;
    using Phoebe.Business;
    using Phoebe.Common;
    using Phoebe.Model;

    /// <summary>
    /// 实时欠费窗体
    /// </summary>
    public partial class DebtForm : BaseForm
    {
        #region Constructor
        public DebtForm()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DebtForm_Load(object sender, EventArgs e)
        {
            this.customerLookup.Init();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.customerLookup.GetSelectedId() == 0)
            {
                MessageUtil.ShowClaim("请选择客户");
                return;
            }

            var customer = BusinessFactory<CustomerBusiness>.Instance.FindById(this.customerLookup.GetSelectedId());

            var contracts = BusinessFactory<ContractBusiness>.Instance.GetByCustomer(customer.Id);
            if (contracts.Count == 0)
            {
                MessageUtil.ShowInfo("该客户无合同");
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            DateTime start = contracts.Min(r => r.SignDate);
            DateTime end = DateTime.Now.Date;

            var debt = BusinessFactory<SettlementBusiness>.Instance.GetDebt(customer.Id, start, end);

            this.txtStartTime.Text = start.ToShortDateString();
            this.txtEndTime.Text = end.ToShortDateString();
            this.txtSettleFee.Text = debt.SettleFee.ToString("f2") + " 元";
            this.txtUnSettleFee.Text = debt.UnSettleFee.ToString("f2") + " 元";
            this.txtSumFee.Text = debt.SumFee.ToString("f2") + "元";
            this.txtPaidFee.Text = debt.PaidFee.ToString("f2") + " 元";
            this.txtDebt.Text = debt.DebtFee.ToString("f2") + " 元";

            this.Cursor = Cursors.Default;
        }
        #endregion //Event
    }
}
