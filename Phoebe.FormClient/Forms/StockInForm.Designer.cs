﻿namespace Phoebe.FormClient
{
    partial class StockInForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInForm));
            this.tcStockIn = new DevExpress.XtraTab.XtraTabControl();
            this.tpStockInList = new DevExpress.XtraTab.XtraTabPage();
            this.tvStockIn = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tsStockIn = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbConfirm = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbRevert = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.plBody = new DevExpress.XtraEditors.PanelControl();
            this.plEmpty = new DevExpress.XtraEditors.PanelControl();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.tcStockIn)).BeginInit();
            this.tcStockIn.SuspendLayout();
            this.tpStockInList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tsStockIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBody)).BeginInit();
            this.plBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plEmpty)).BeginInit();
            this.SuspendLayout();
            // 
            // tcStockIn
            // 
            this.tcStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStockIn.Location = new System.Drawing.Point(2, 21);
            this.tcStockIn.Name = "tcStockIn";
            this.tcStockIn.SelectedTabPage = this.tpStockInList;
            this.tcStockIn.Size = new System.Drawing.Size(212, 543);
            this.tcStockIn.TabIndex = 0;
            this.tcStockIn.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpStockInList,
            this.xtraTabPage2});
            // 
            // tpStockInList
            // 
            this.tpStockInList.Controls.Add(this.tvStockIn);
            this.tpStockInList.Name = "tpStockInList";
            this.tpStockInList.Size = new System.Drawing.Size(206, 514);
            this.tpStockInList.Text = "列表";
            // 
            // tvStockIn
            // 
            this.tvStockIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvStockIn.ImageIndex = 0;
            this.tvStockIn.ImageList = this.imageList1;
            this.tvStockIn.Location = new System.Drawing.Point(0, 0);
            this.tvStockIn.Name = "tvStockIn";
            this.tvStockIn.SelectedImageIndex = 0;
            this.tvStockIn.Size = new System.Drawing.Size(206, 514);
            this.tvStockIn.TabIndex = 0;
            this.tvStockIn.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvStockIn_BeforeExpand);
            this.tvStockIn.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvStockIn_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BONote_16x16.png");
            this.imageList1.Images.SetKeyName(1, "BOProduct_16x16.png");
            this.imageList1.Images.SetKeyName(2, "BOOrder_16x16.png");
            this.imageList1.Images.SetKeyName(3, "BOSaleItem_16x16.png");
            this.imageList1.Images.SetKeyName(4, "BOOrderItem_16x16.png");
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(206, 514);
            this.xtraTabPage2.Text = "查询";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tcStockIn);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(216, 566);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "导航";
            // 
            // tsStockIn
            // 
            this.tsStockIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbClose,
            this.tsbSave,
            this.tsbConfirm,
            this.toolStripSeparator,
            this.tsbEdit,
            this.tsbRevert,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbPrint});
            this.tsStockIn.Location = new System.Drawing.Point(216, 0);
            this.tsStockIn.Name = "tsStockIn";
            this.tsStockIn.Size = new System.Drawing.Size(748, 25);
            this.tsStockIn.TabIndex = 7;
            this.tsStockIn.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = global::Phoebe.FormClient.Properties.Resources.AddFile_16x16;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(52, 22);
            this.tsbNew.Text = "新建";
            this.tsbNew.ToolTipText = "新建";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::Phoebe.FormClient.Properties.Resources.Save_16x16;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbConfirm
            // 
            this.tsbConfirm.Image = global::Phoebe.FormClient.Properties.Resources.Apply_16x16;
            this.tsbConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConfirm.Name = "tsbConfirm";
            this.tsbConfirm.Size = new System.Drawing.Size(76, 22);
            this.tsbConfirm.Text = "入库确认";
            this.tsbConfirm.Click += new System.EventHandler(this.tsbConfirm_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::Phoebe.FormClient.Properties.Resources.Print_16x16;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(52, 22);
            this.tsbPrint.Text = "打印";
            this.tsbPrint.Click += new System.EventHandler(this.tsbPrint_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::Phoebe.FormClient.Properties.Resources.EditName_16x16;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(52, 22);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbRevert
            // 
            this.tsbRevert.Image = global::Phoebe.FormClient.Properties.Resources.Reset_16x16;
            this.tsbRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRevert.Name = "tsbRevert";
            this.tsbRevert.Size = new System.Drawing.Size(52, 22);
            this.tsbRevert.Text = "撤回";
            this.tsbRevert.Click += new System.EventHandler(this.tsbRevert_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Phoebe.FormClient.Properties.Resources.Remove_16x16;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // plBody
            // 
            this.plBody.Appearance.BackColor = System.Drawing.Color.White;
            this.plBody.Appearance.Options.UseBackColor = true;
            this.plBody.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.plBody.Controls.Add(this.plEmpty);
            this.plBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBody.Location = new System.Drawing.Point(216, 25);
            this.plBody.Name = "plBody";
            this.plBody.Size = new System.Drawing.Size(748, 541);
            this.plBody.TabIndex = 8;
            // 
            // plEmpty
            // 
            this.plEmpty.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.plEmpty.Dock = System.Windows.Forms.DockStyle.Top;
            this.plEmpty.Location = new System.Drawing.Point(0, 0);
            this.plEmpty.Name = "plEmpty";
            this.plEmpty.Size = new System.Drawing.Size(748, 100);
            this.plEmpty.TabIndex = 0;
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::Phoebe.FormClient.Properties.Resources.Close_16x16;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(52, 22);
            this.tsbClose.Text = "关闭";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // StockInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 566);
            this.Controls.Add(this.plBody);
            this.Controls.Add(this.tsStockIn);
            this.Controls.Add(this.groupControl1);
            this.Name = "StockInForm";
            this.Text = "货品入库";
            this.Load += new System.EventHandler(this.StockInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tcStockIn)).EndInit();
            this.tcStockIn.ResumeLayout(false);
            this.tpStockInList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tsStockIn.ResumeLayout(false);
            this.tsStockIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBody)).EndInit();
            this.plBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plEmpty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcStockIn;
        private DevExpress.XtraTab.XtraTabPage tpStockInList;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ToolStrip tsStockIn;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private DevExpress.XtraEditors.PanelControl plBody;
        private System.Windows.Forms.TreeView tvStockIn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton tsbConfirm;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbRevert;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private DevExpress.XtraEditors.PanelControl plEmpty;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}