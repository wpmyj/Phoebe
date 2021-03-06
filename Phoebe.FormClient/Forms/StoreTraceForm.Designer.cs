﻿namespace Phoebe.FormClient
{
    partial class StoreTraceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnDeleteFlow = new DevExpress.XtraEditors.SimpleButton();
            this.btnFix = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrace = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.rbStoreOut = new System.Windows.Forms.RadioButton();
            this.rbStoreIn = new System.Windows.Forms.RadioButton();
            this.txtCategoryName = new DevExpress.XtraEditors.TextEdit();
            this.txtCategoryNumber = new DevExpress.XtraEditors.TextEdit();
            this.cmbContract = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.sgList = new Phoebe.FormClient.StoreGrid();
            this.clcCategory = new Phoebe.FormClient.CategoryListControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.sfgList = new Phoebe.FormClient.StockFlowGrid();
            this.customerLookup = new Phoebe.FormClient.CustomerLookup();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContract.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.clcCategory, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 610);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl1, 2);
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(773, 194);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "库存查询";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.customerLookup);
            this.layoutControl1.Controls.Add(this.btnDeleteFlow);
            this.layoutControl1.Controls.Add(this.btnFix);
            this.layoutControl1.Controls.Add(this.btnTrace);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.rbStoreOut);
            this.layoutControl1.Controls.Add(this.rbStoreIn);
            this.layoutControl1.Controls.Add(this.txtCategoryName);
            this.layoutControl1.Controls.Add(this.txtCategoryNumber);
            this.layoutControl1.Controls.Add(this.cmbContract);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(769, 171);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnDeleteFlow
            // 
            this.btnDeleteFlow.Location = new System.Drawing.Point(507, 91);
            this.btnDeleteFlow.Name = "btnDeleteFlow";
            this.btnDeleteFlow.Size = new System.Drawing.Size(250, 22);
            this.btnDeleteFlow.StyleController = this.layoutControl1;
            this.btnDeleteFlow.TabIndex = 14;
            this.btnDeleteFlow.Text = "删除流水";
            this.btnDeleteFlow.Click += new System.EventHandler(this.btnDeleteFlow_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(507, 65);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(250, 22);
            this.btnFix.StyleController = this.layoutControl1;
            this.btnFix.TabIndex = 12;
            this.btnFix.Text = "修正流水";
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnTrace
            // 
            this.btnTrace.Location = new System.Drawing.Point(255, 65);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(248, 22);
            this.btnTrace.StyleController = this.layoutControl1;
            this.btnTrace.TabIndex = 11;
            this.btnTrace.Text = "追溯";
            this.btnTrace.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(239, 22);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbStoreOut
            // 
            this.rbStoreOut.Location = new System.Drawing.Point(582, 36);
            this.rbStoreOut.Name = "rbStoreOut";
            this.rbStoreOut.Size = new System.Drawing.Size(74, 25);
            this.rbStoreOut.TabIndex = 10;
            this.rbStoreOut.Text = "出库";
            this.rbStoreOut.UseVisualStyleBackColor = true;
            // 
            // rbStoreIn
            // 
            this.rbStoreIn.Checked = true;
            this.rbStoreIn.Location = new System.Drawing.Point(507, 36);
            this.rbStoreIn.Name = "rbStoreIn";
            this.rbStoreIn.Size = new System.Drawing.Size(71, 25);
            this.rbStoreIn.TabIndex = 9;
            this.rbStoreIn.TabStop = true;
            this.rbStoreIn.Text = "在库";
            this.rbStoreIn.UseVisualStyleBackColor = true;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(306, 36);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtCategoryName.Properties.Appearance.Options.UseBackColor = true;
            this.txtCategoryName.Size = new System.Drawing.Size(197, 20);
            this.txtCategoryName.StyleController = this.layoutControl1;
            this.txtCategoryName.TabIndex = 8;
            // 
            // txtCategoryNumber
            // 
            this.txtCategoryNumber.Location = new System.Drawing.Point(63, 36);
            this.txtCategoryNumber.Name = "txtCategoryNumber";
            this.txtCategoryNumber.Properties.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.txtCategoryNumber.Properties.Appearance.Options.UseBackColor = true;
            this.txtCategoryNumber.Size = new System.Drawing.Size(188, 20);
            this.txtCategoryNumber.StyleController = this.layoutControl1;
            this.txtCategoryNumber.TabIndex = 7;
            this.txtCategoryNumber.EditValueChanged += new System.EventHandler(this.txtCategoryNumber_EditValueChanged);
            // 
            // cmbContract
            // 
            this.cmbContract.Location = new System.Drawing.Point(558, 12);
            this.cmbContract.Name = "cmbContract";
            this.cmbContract.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbContract.Size = new System.Drawing.Size(199, 20);
            this.cmbContract.StyleController = this.layoutControl1;
            this.cmbContract.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem2,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(769, 171);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbContract;
            this.layoutControlItem3.Location = new System.Drawing.Point(495, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(254, 24);
            this.layoutControlItem3.Text = "所属合同";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCategoryNumber;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(243, 24);
            this.layoutControlItem4.Text = "分类代码";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtCategoryName;
            this.layoutControlItem5.Location = new System.Drawing.Point(243, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(252, 24);
            this.layoutControlItem5.Text = "分类名称";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.rbStoreIn;
            this.layoutControlItem6.Location = new System.Drawing.Point(495, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(75, 29);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.rbStoreOut;
            this.layoutControlItem7.Location = new System.Drawing.Point(570, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(78, 29);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(648, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(101, 29);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnSearch;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(243, 103);
            this.layoutControlItem8.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnTrace;
            this.layoutControlItem9.Location = new System.Drawing.Point(243, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(252, 103);
            this.layoutControlItem9.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnFix;
            this.layoutControlItem10.Location = new System.Drawing.Point(495, 53);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(254, 26);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnDeleteFlow;
            this.layoutControlItem2.Location = new System.Drawing.Point(495, 79);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(254, 72);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // groupControl2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl2, 3);
            this.groupControl2.Controls.Add(this.sgList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 203);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(973, 199);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "库存列表";
            // 
            // sgList
            // 
            this.sgList.DataSource = null;
            this.sgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgList.EnableColumn = true;
            this.sgList.EnableFilter = true;
            this.sgList.EnableFind = false;
            this.sgList.EnableGroup = false;
            this.sgList.Location = new System.Drawing.Point(2, 21);
            this.sgList.Margin = new System.Windows.Forms.Padding(4);
            this.sgList.Name = "sgList";
            this.sgList.ShowContract = false;
            this.sgList.ShowCustomer = false;
            this.sgList.ShowFooter = true;
            this.sgList.Size = new System.Drawing.Size(969, 176);
            this.sgList.TabIndex = 0;
            // 
            // clcCategory
            // 
            this.clcCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clcCategory.Location = new System.Drawing.Point(783, 4);
            this.clcCategory.Margin = new System.Windows.Forms.Padding(4);
            this.clcCategory.Name = "clcCategory";
            this.clcCategory.Size = new System.Drawing.Size(192, 192);
            this.clcCategory.TabIndex = 3;
            this.clcCategory.CategoryItemSelected += new Phoebe.FormClient.CategoryListControl.ItemSelectHandle(this.clcCategory_CategoryItemSelected);
            // 
            // groupControl3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupControl3, 3);
            this.groupControl3.Controls.Add(this.sfgList);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 408);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(973, 199);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "流水记录";
            // 
            // sfgList
            // 
            this.sfgList.DataSource = null;
            this.sfgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfgList.EndDate = new System.DateTime(((long)(0)));
            this.sfgList.Location = new System.Drawing.Point(2, 21);
            this.sfgList.Margin = new System.Windows.Forms.Padding(4);
            this.sfgList.Name = "sfgList";
            this.sfgList.Size = new System.Drawing.Size(969, 176);
            this.sfgList.StartDate = new System.DateTime(((long)(0)));
            this.sfgList.TabIndex = 0;
            // 
            // customerLookup
            // 
            this.customerLookup.Location = new System.Drawing.Point(63, 12);
            this.customerLookup.Name = "customerLookup";
            this.customerLookup.Size = new System.Drawing.Size(440, 20);
            this.customerLookup.TabIndex = 15;
            this.customerLookup.CustomerSelect += new System.EventHandler(this.customerLookup_CustomerSelect);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.customerLookup;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(495, 24);
            this.layoutControlItem11.Text = "客户选择";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(48, 14);
            // 
            // StoreTraceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 610);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StoreTraceForm";
            this.Text = "库存追溯";
            this.Load += new System.EventHandler(this.StoreTraceForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategoryNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContract.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbContract;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private StoreGrid sgList;
        private DevExpress.XtraEditors.TextEdit txtCategoryName;
        private DevExpress.XtraEditors.TextEdit txtCategoryNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.RadioButton rbStoreOut;
        private System.Windows.Forms.RadioButton rbStoreIn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private CategoryListControl clcCategory;
        private DevExpress.XtraEditors.SimpleButton btnTrace;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private StockFlowGrid sfgList;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnFix;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.SimpleButton btnDeleteFlow;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private CustomerLookup customerLookup;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
    }
}