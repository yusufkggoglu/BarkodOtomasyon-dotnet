namespace Forms
{
    partial class OutgoingReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutgoingReportForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbxSum = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClean = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDateFilter = new DevExpress.XtraEditors.SimpleButton();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tbxPaymentMethod = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new DevExpress.XtraEditors.LabelControl();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new DevExpress.XtraEditors.LabelControl();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new DevExpress.XtraEditors.LabelControl();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.dqw = new System.Windows.Forms.DataGridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.tbxSum);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnClean);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnDateFilter);
            this.groupControl1.Controls.Add(this.dtpFinish);
            this.groupControl1.Controls.Add(this.dtpStart);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.tbxPaymentMethod);
            this.groupControl1.Controls.Add(this.lblPaymentMethod);
            this.groupControl1.Controls.Add(this.tbxUnitPrice);
            this.groupControl1.Controls.Add(this.lblUnitPrice);
            this.groupControl1.Controls.Add(this.tbxAmount);
            this.groupControl1.Controls.Add(this.lblAmount);
            this.groupControl1.Controls.Add(this.tbxName);
            this.groupControl1.Controls.Add(this.lblName);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            // 
            // tbxSum
            // 
            resources.ApplyResources(this.tbxSum, "tbxSum");
            this.tbxSum.Name = "tbxSum";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnSave.Appearance.Font")));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClean
            // 
            this.btnClean.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnClean.Appearance.Font")));
            this.btnClean.Appearance.Options.UseFont = true;
            this.btnClean.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClean.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnClean, "btnClean");
            this.btnClean.Name = "btnClean";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnDateFilter.Appearance.Font")));
            this.btnDateFilter.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnDateFilter, "btnDateFilter");
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Click += new System.EventHandler(this.btnDateFilter_Click);
            // 
            // dtpFinish
            // 
            resources.ApplyResources(this.dtpFinish, "dtpFinish");
            this.dtpFinish.Name = "dtpFinish";
            // 
            // dtpStart
            // 
            resources.ApplyResources(this.dtpStart, "dtpStart");
            this.dtpStart.Name = "dtpStart";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnUpdate.Appearance.Font")));
            this.btnUpdate.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Appearance.Font")));
            this.btnAdd.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxPaymentMethod
            // 
            resources.ApplyResources(this.tbxPaymentMethod, "tbxPaymentMethod");
            this.tbxPaymentMethod.Name = "tbxPaymentMethod";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblPaymentMethod.Appearance.Font")));
            this.lblPaymentMethod.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblPaymentMethod, "lblPaymentMethod");
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            // 
            // tbxUnitPrice
            // 
            resources.ApplyResources(this.tbxUnitPrice, "tbxUnitPrice");
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblUnitPrice.Appearance.Font")));
            this.lblUnitPrice.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblUnitPrice, "lblUnitPrice");
            this.lblUnitPrice.Name = "lblUnitPrice";
            // 
            // tbxAmount
            // 
            resources.ApplyResources(this.tbxAmount, "tbxAmount");
            this.tbxAmount.Name = "tbxAmount";
            // 
            // lblAmount
            // 
            this.lblAmount.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblAmount.Appearance.Font")));
            this.lblAmount.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblAmount, "lblAmount");
            this.lblAmount.Name = "lblAmount";
            // 
            // tbxName
            // 
            resources.ApplyResources(this.tbxName, "tbxName");
            this.tbxName.Name = "tbxName";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblName.Appearance.Font")));
            this.lblName.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // dqw
            // 
            this.dqw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dqw, "dqw");
            this.dqw.Name = "dqw";
            this.dqw.RowTemplate.Height = 24;
            this.dqw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqw_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnDelete.Appearance.Font")));
            this.btnDelete.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // OutcomeReportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dqw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OutcomeReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.OutcomeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dqw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClean;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDateFilter;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox tbxPaymentMethod;
        private DevExpress.XtraEditors.LabelControl lblPaymentMethod;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private DevExpress.XtraEditors.LabelControl lblUnitPrice;
        private System.Windows.Forms.TextBox tbxAmount;
        private DevExpress.XtraEditors.LabelControl lblAmount;
        private System.Windows.Forms.TextBox tbxName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private System.Windows.Forms.DataGridView dqw;
        private System.Windows.Forms.TextBox tbxSum;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}