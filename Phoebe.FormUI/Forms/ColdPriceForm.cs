﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phoebe.Business;
using Phoebe.Common;
using Phoebe.Model;

namespace Phoebe.FormUI
{
    /// <summary>
    /// 冷藏费清单窗体
    /// </summary>
    public partial class ColdPriceForm : Form
    {
        #region Field
        private SettleBusiness settleBusiness;

        private CustomerBusiness customerBusiness;

        private ContractBusiness contractBusiness;

        private CargoBusiness cargoBusiness;
        #endregion //Field

        #region Constructor
        public ColdPriceForm()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        private void InitData()
        {
            this.settleBusiness = new SettleBusiness();
            this.customerBusiness = new CustomerBusiness();
            this.contractBusiness = new ContractBusiness();
            this.cargoBusiness = new CargoBusiness();
        }

        private void InitControl()
        {
            this.comboBoxCustomer.DataSource = this.customerBusiness.Get();
            this.comboBoxCustomer.DisplayMember = "Name";
            this.comboBoxCustomer.ValueMember = "ID";
        }
        #endregion //Function

        #region Event
        private void ColdPriceForm_Load(object sender, EventArgs e)
        {
            InitData();
            InitControl();
        }                

        /// <summary>
        /// 客户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxCustomer.SelectedIndex == -1)
                return;

            var customer = this.comboBoxCustomer.SelectedItem as Customer;

            var contracts = this.contractBusiness.GetByCustomer(customer.ID);
            contracts.Insert(0, new Contract { ID = 0, Name = "--请选择--" });

            this.comboBoxContract.DataSource = contracts;
            this.comboBoxContract.DisplayMember = "Name";
            this.comboBoxContract.ValueMember = "ID";

            this.comboBoxCargo.DataSource = null;
        }
        
        /// <summary>
        /// 合同选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxContract.SelectedIndex == -1 || this.comboBoxContract.SelectedIndex == 0)
                return;

            var contract = this.comboBoxContract.SelectedItem as Contract;
            var cargos = this.cargoBusiness.GetByContract(contract.ID).Where(r => r.Status != (int)EntityStatus.CargoNotIn).ToList();
            cargos.Insert(0, new Cargo { Name = "--请选择--" });

            this.comboBoxCargo.DataSource = cargos;
            this.comboBoxCargo.DisplayMember = "Name";
            this.comboBoxCargo.ValueMember = "ID";
        }
        
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            if (this.radioContract.Checked)
            {

            }
            else
            {
                if (this.comboBoxCargo.SelectedIndex == -1 || this.comboBoxCargo.SelectedIndex == 0)
                {
                    MessageBox.Show("未选择货品", FormConstant.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var cargo = this.comboBoxCargo.SelectedItem as Cargo;

                var records= this.settleBusiness.ProcessDailyCold(cargo.ID, dateStart.Value.Date, dateEnd.Value.Date);
                this.dailyColdRecordBindingSource.DataSource = records;
            }
        }
        #endregion //Event
    }
}
