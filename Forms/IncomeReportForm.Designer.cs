namespace Forms
{
    partial class IncomeReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeReportForm));
            this.dqw = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbxSum = new System.Windows.Forms.TextBox();
            this.lblSum = new DevExpress.XtraEditors.LabelControl();
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
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dqw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqw
            // 
            this.dqw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dqw.Location = new System.Drawing.Point(12, 301);
            this.dqw.Name = "dqw";
            this.dqw.RowTemplate.Height = 24;
            this.dqw.Size = new System.Drawing.Size(1888, 546);
            this.dqw.TabIndex = 0;
            this.dqw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqw_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.tbxSum);
            this.groupControl1.Controls.Add(this.lblSum);
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
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1888, 283);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // tbxSum
            // 
            this.tbxSum.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbxSum.Location = new System.Drawing.Point(981, 189);
            this.tbxSum.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSum.Name = "tbxSum";
            this.tbxSum.Size = new System.Drawing.Size(200, 28);
            this.tbxSum.TabIndex = 29;
            // 
            // lblSum
            // 
            this.lblSum.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblSum.Appearance.Options.UseFont = true;
            this.lblSum.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSum.Location = new System.Drawing.Point(846, 187);
            this.lblSum.Margin = new System.Windows.Forms.Padding(4);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(129, 32);
            this.lblSum.TabIndex = 28;
            this.lblSum.Text = "Toplam  Gelir";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(1377, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 89);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Excel\'e Aktar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClean
            // 
            this.btnClean.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClean.Appearance.Options.UseFont = true;
            this.btnClean.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClean.ImageOptions.SvgImage")));
            this.btnClean.Location = new System.Drawing.Point(1377, 128);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(167, 89);
            this.btnClean.TabIndex = 27;
            this.btnClean.Text = "Temizle";
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(846, 100);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 32);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Bitiş";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(1881, 43);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 89);
            this.simpleButton1.TabIndex = 25;
            this.simpleButton1.Text = "Başlangıç ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(846, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 32);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Başlangıç ";
            // 
            // btnDateFilter
            // 
            this.btnDateFilter.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDateFilter.Appearance.Options.UseFont = true;
            this.btnDateFilter.Location = new System.Drawing.Point(1202, 39);
            this.btnDateFilter.Name = "btnDateFilter";
            this.btnDateFilter.Size = new System.Drawing.Size(104, 89);
            this.btnDateFilter.TabIndex = 23;
            this.btnDateFilter.Text = "Filtrele";
            this.btnDateFilter.Click += new System.EventHandler(this.btnDateFilter_Click);
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(981, 105);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(200, 23);
            this.dtpFinish.TabIndex = 22;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(981, 39);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 23);
            this.dtpStart.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(537, 114);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 60);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Location = new System.Drawing.Point(537, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 64);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Kaydet";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxPaymentMethod
            // 
            this.tbxPaymentMethod.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbxPaymentMethod.Location = new System.Drawing.Point(258, 220);
            this.tbxPaymentMethod.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPaymentMethod.Name = "tbxPaymentMethod";
            this.tbxPaymentMethod.Size = new System.Drawing.Size(252, 28);
            this.tbxPaymentMethod.TabIndex = 18;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblPaymentMethod.Appearance.Options.UseFont = true;
            this.lblPaymentMethod.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPaymentMethod.Location = new System.Drawing.Point(79, 216);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(171, 32);
            this.lblPaymentMethod.TabIndex = 17;
            this.lblPaymentMethod.Text = "Ödeme Yöntemi";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbxUnitPrice.Location = new System.Drawing.Point(258, 160);
            this.tbxUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(252, 28);
            this.tbxUnitPrice.TabIndex = 16;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblUnitPrice.Appearance.Options.UseFont = true;
            this.lblUnitPrice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUnitPrice.Location = new System.Drawing.Point(79, 156);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(171, 32);
            this.lblUnitPrice.TabIndex = 15;
            this.lblUnitPrice.Text = "Adet Fiyatı";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbxAmount.Location = new System.Drawing.Point(258, 95);
            this.tbxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(252, 28);
            this.tbxAmount.TabIndex = 14;
            // 
            // lblAmount
            // 
            this.lblAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblAmount.Appearance.Options.UseFont = true;
            this.lblAmount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAmount.Location = new System.Drawing.Point(79, 91);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(171, 32);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Adet";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbxName.Location = new System.Drawing.Point(258, 34);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(252, 28);
            this.tbxName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblName.Location = new System.Drawing.Point(79, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(171, 32);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Ürün";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(537, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 60);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // IncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 859);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dqw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IncomeReportForm";
            this.Text = "Gelir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IncomeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqw;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox tbxPaymentMethod;
        private DevExpress.XtraEditors.LabelControl lblPaymentMethod;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private DevExpress.XtraEditors.LabelControl lblUnitPrice;
        private System.Windows.Forms.TextBox tbxAmount;
        private DevExpress.XtraEditors.LabelControl lblAmount;
        private System.Windows.Forms.TextBox tbxName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDateFilter;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClean;
        private System.Windows.Forms.TextBox tbxSum;
        private DevExpress.XtraEditors.LabelControl lblSum;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}