﻿namespace Forms
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbKamera = new System.Windows.Forms.ComboBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxSalePrice = new System.Windows.Forms.TextBox();
            this.tbxPurhasePrice = new System.Windows.Forms.TextBox();
            this.lblDiscount = new DevExpress.XtraEditors.LabelControl();
            this.lblStockAmount = new DevExpress.XtraEditors.LabelControl();
            this.lblSalePrice = new DevExpress.XtraEditors.LabelControl();
            this.lblPurchasePrice = new DevExpress.XtraEditors.LabelControl();
            this.lblProductName = new DevExpress.XtraEditors.LabelControl();
            this.lblBarcode = new DevExpress.XtraEditors.LabelControl();
            this.dqwProducts = new System.Windows.Forms.DataGridView();
            this.btnRead = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.groupControl1);
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnRead);
            this.groupControl1.Controls.Add(this.cmbKamera);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.tbxDiscount);
            this.groupControl1.Controls.Add(this.tbxStockAmount);
            this.groupControl1.Controls.Add(this.tbxBarcode);
            this.groupControl1.Controls.Add(this.tbxProductName);
            this.groupControl1.Controls.Add(this.tbxSalePrice);
            this.groupControl1.Controls.Add(this.tbxPurhasePrice);
            this.groupControl1.Controls.Add(this.lblDiscount);
            this.groupControl1.Controls.Add(this.lblStockAmount);
            this.groupControl1.Controls.Add(this.lblSalePrice);
            this.groupControl1.Controls.Add(this.lblPurchasePrice);
            this.groupControl1.Controls.Add(this.lblProductName);
            this.groupControl1.Controls.Add(this.lblBarcode);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            // 
            // cmbKamera
            // 
            resources.ApplyResources(this.cmbKamera, "cmbKamera");
            this.cmbKamera.FormattingEnabled = true;
            this.cmbKamera.Name = "cmbKamera";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Appearance.Font")));
            this.btnAdd.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxDiscount
            // 
            resources.ApplyResources(this.tbxDiscount, "tbxDiscount");
            this.tbxDiscount.Name = "tbxDiscount";
            // 
            // tbxStockAmount
            // 
            resources.ApplyResources(this.tbxStockAmount, "tbxStockAmount");
            this.tbxStockAmount.Name = "tbxStockAmount";
            // 
            // tbxBarcode
            // 
            resources.ApplyResources(this.tbxBarcode, "tbxBarcode");
            this.tbxBarcode.Name = "tbxBarcode";
            // 
            // tbxProductName
            // 
            resources.ApplyResources(this.tbxProductName, "tbxProductName");
            this.tbxProductName.Name = "tbxProductName";
            // 
            // tbxSalePrice
            // 
            resources.ApplyResources(this.tbxSalePrice, "tbxSalePrice");
            this.tbxSalePrice.Name = "tbxSalePrice";
            // 
            // tbxPurhasePrice
            // 
            resources.ApplyResources(this.tbxPurhasePrice, "tbxPurhasePrice");
            this.tbxPurhasePrice.Name = "tbxPurhasePrice";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblDiscount.Appearance.Font")));
            this.lblDiscount.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblDiscount, "lblDiscount");
            this.lblDiscount.Name = "lblDiscount";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblStockAmount.Appearance.Font")));
            this.lblStockAmount.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblStockAmount, "lblStockAmount");
            this.lblStockAmount.Name = "lblStockAmount";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblSalePrice.Appearance.Font")));
            this.lblSalePrice.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblSalePrice, "lblSalePrice");
            this.lblSalePrice.Name = "lblSalePrice";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblPurchasePrice.Appearance.Font")));
            this.lblPurchasePrice.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblPurchasePrice, "lblPurchasePrice");
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            // 
            // lblProductName
            // 
            this.lblProductName.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblProductName.Appearance.Font")));
            this.lblProductName.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblProductName, "lblProductName");
            this.lblProductName.Name = "lblProductName";
            // 
            // lblBarcode
            // 
            this.lblBarcode.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblBarcode.Appearance.Font")));
            this.lblBarcode.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblBarcode, "lblBarcode");
            this.lblBarcode.Name = "lblBarcode";
            // 
            // dqwProducts
            // 
            this.dqwProducts.AllowUserToAddRows = false;
            this.dqwProducts.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dqwProducts, "dqwProducts");
            this.dqwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqwProducts.Name = "dqwProducts";
            this.dqwProducts.ReadOnly = true;
            this.dqwProducts.RowTemplate.Height = 24;
            this.dqwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwProducts_CellClick);
            // 
            // btnRead
            // 
            resources.ApplyResources(this.btnRead, "btnRead");
            this.btnRead.Name = "btnRead";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.btnDelete.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            // 
            // AddProductForm
            // 
            this.Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dqwProducts);
            this.Controls.Add(this.sidePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProductForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqwProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblBarcode;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxBarcode;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxSalePrice;
        private System.Windows.Forms.TextBox tbxPurhasePrice;
        private DevExpress.XtraEditors.LabelControl lblDiscount;
        private DevExpress.XtraEditors.LabelControl lblStockAmount;
        private DevExpress.XtraEditors.LabelControl lblSalePrice;
        private DevExpress.XtraEditors.LabelControl lblPurchasePrice;
        private DevExpress.XtraEditors.LabelControl lblProductName;
        private System.Windows.Forms.DataGridView dqwProducts;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.ComboBox cmbKamera;
        private DevExpress.XtraEditors.SimpleButton btnRead;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}