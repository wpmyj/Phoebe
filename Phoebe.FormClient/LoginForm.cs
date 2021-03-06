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
    /// 系统登录窗体
    /// </summary>
    public partial class LoginForm : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 用户
        /// </summary>
        private User user;
        #endregion //Field

        #region Constructor
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function

        #endregion //Function

        #region Event
        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text.Trim();

            if (userName == "")
            {
                MessageUtil.ShowClaim("用户名不能为空");
                return;
            }

            if (this.txtPassword.Text == "")
            {
                MessageUtil.ShowClaim("密码不能为空");
                return;
            }

            ErrorCode result = BusinessFactory<UserBusiness>.Instance.Login(userName, this.txtPassword.Text);

            if (result == ErrorCode.Success)
            {
                this.user = BusinessFactory<UserBusiness>.Instance.Get(userName);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageUtil.ShowWarning(result.DisplayName());
                this.txtPassword.Text = "";
                return;
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 登录用户
        /// </summary>
        public User User
        {
            get
            {
                return this.user;
            }
        }
        #endregion //Property
    }
}
