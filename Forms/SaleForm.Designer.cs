namespace Forms
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.dqw = new System.Windows.Forms.DataGridView();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxBarcode = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cmbKamera = new System.Windows.Forms.ComboBox();
            this.tbxMoney = new System.Windows.Forms.TextBox();
            this.btn1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn6 = new DevExpress.XtraEditors.SimpleButton();
            this.btn7 = new DevExpress.XtraEditors.SimpleButton();
            this.btn8 = new DevExpress.XtraEditors.SimpleButton();
            this.btn9 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btn0 = new DevExpress.XtraEditors.SimpleButton();
            this.btnComma = new DevExpress.XtraEditors.SimpleButton();
            this.btnOtherProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnBarcode = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaled = new DevExpress.XtraEditors.SimpleButton();
            this.btnAmount = new DevExpress.XtraEditors.SimpleButton();
            this.btnCash = new DevExpress.XtraEditors.SimpleButton();
            this.btnCard = new DevExpress.XtraEditors.SimpleButton();
            this.btnCashCard = new DevExpress.XtraEditors.SimpleButton();
            this.tbxSum = new System.Windows.Forms.TextBox();
            this.btn10 = new DevExpress.XtraEditors.SimpleButton();
            this.btn50 = new DevExpress.XtraEditors.SimpleButton();
            this.btn100 = new DevExpress.XtraEditors.SimpleButton();
            this.btn200 = new DevExpress.XtraEditors.SimpleButton();
            this.tbxSaled = new System.Windows.Forms.TextBox();
            this.tbxChange = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dqw)).BeginInit();
            this.SuspendLayout();
            // 
            // flp
            // 
            resources.ApplyResources(this.flp, "flp");
            this.flp.Name = "flp";
            // 
            // dqw
            // 
            this.dqw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dqw, "dqw");
            this.dqw.Name = "dqw";
            this.dqw.RowTemplate.Height = 24;
            // 
            // tbxAmount
            // 
            resources.ApplyResources(this.tbxAmount, "tbxAmount");
            this.tbxAmount.Name = "tbxAmount";
            // 
            // tbxBarcode
            // 
            resources.ApplyResources(this.tbxBarcode, "tbxBarcode");
            this.tbxBarcode.Name = "tbxBarcode";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbKamera
            // 
            this.cmbKamera.FormattingEnabled = true;
            resources.ApplyResources(this.cmbKamera, "cmbKamera");
            this.cmbKamera.Name = "cmbKamera";
            // 
            // tbxMoney
            // 
            resources.ApplyResources(this.tbxMoney, "tbxMoney");
            this.tbxMoney.Name = "tbxMoney";
            // 
            // btn1
            // 
            this.btn1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.btn1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn1, "btn1");
            this.btn1.Name = "btn1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font")));
            this.btn2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn2, "btn2");
            this.btn2.Name = "btn2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font")));
            this.btn3.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn3, "btn3");
            this.btn3.Name = "btn3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton4.Appearance.Font")));
            this.btn4.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn4, "btn4");
            this.btn4.Name = "btn4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton5.Appearance.Font")));
            this.btn5.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn5, "btn5");
            this.btn5.Name = "btn5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton6.Appearance.Font")));
            this.btn6.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn6, "btn6");
            this.btn6.Name = "btn6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton7.Appearance.Font")));
            this.btn7.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn7, "btn7");
            this.btn7.Name = "btn7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton8.Appearance.Font")));
            this.btn8.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn8, "btn8");
            this.btn8.Name = "btn8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton9.Appearance.Font")));
            this.btn9.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn9, "btn9");
            this.btn9.Name = "btn9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton10.Appearance.Font")));
            this.btnClear.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton11.Appearance.Font")));
            this.btn0.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn0, "btn0");
            this.btn0.Name = "btn0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnComma
            // 
            this.btnComma.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton12.Appearance.Font")));
            this.btnComma.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnComma, "btnComma");
            this.btnComma.Name = "btnComma";
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btnOtherProduct
            // 
            this.btnOtherProduct.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font1")));
            this.btnOtherProduct.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnOtherProduct, "btnOtherProduct");
            this.btnOtherProduct.Name = "btnOtherProduct";
            this.btnOtherProduct.Click += new System.EventHandler(this.btnOtherProduct_Click);
            // 
            // btnBarcode
            // 
            this.btnBarcode.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnBarcode.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font2")));
            this.btnBarcode.Appearance.Options.UseBackColor = true;
            this.btnBarcode.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnBarcode, "btnBarcode");
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Click += new System.EventHandler(this.btnBarcode_Click);
            // 
            // btnSaled
            // 
            this.btnSaled.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font3")));
            this.btnSaled.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnSaled, "btnSaled");
            this.btnSaled.Name = "btnSaled";
            this.btnSaled.Click += new System.EventHandler(this.btnSaled_Click);
            // 
            // btnAmount
            // 
            this.btnAmount.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnAmount.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font4")));
            this.btnAmount.Appearance.Options.UseBackColor = true;
            this.btnAmount.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnAmount, "btnAmount");
            this.btnAmount.Name = "btnAmount";
            this.btnAmount.Click += new System.EventHandler(this.btnAmount_Click);
            // 
            // btnCash
            // 
            this.btnCash.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCash.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font5")));
            this.btnCash.Appearance.Options.UseBackColor = true;
            this.btnCash.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnCash, "btnCash");
            this.btnCash.Name = "btnCash";
            this.btnCash.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnCard
            // 
            this.btnCard.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCard.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font1")));
            this.btnCard.Appearance.Options.UseBackColor = true;
            this.btnCard.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnCard, "btnCard");
            this.btnCard.Name = "btnCard";
            this.btnCard.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnCashCard
            // 
            this.btnCashCard.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCashCard.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font1")));
            this.btnCashCard.Appearance.Options.UseBackColor = true;
            this.btnCashCard.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnCashCard, "btnCashCard");
            this.btnCashCard.Name = "btnCashCard";
            this.btnCashCard.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tbxSum
            // 
            resources.ApplyResources(this.tbxSum, "tbxSum");
            this.tbxSum.Name = "tbxSum";
            // 
            // btn10
            // 
            this.btn10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn10.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton6.Appearance.Font1")));
            this.btn10.Appearance.Options.UseBackColor = true;
            this.btn10.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn10, "btn10");
            this.btn10.Name = "btn10";
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn50
            // 
            this.btn50.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn50.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton7.Appearance.Font1")));
            this.btn50.Appearance.Options.UseBackColor = true;
            this.btn50.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn50, "btn50");
            this.btn50.Name = "btn50";
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn100
            // 
            this.btn100.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn100.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton8.Appearance.Font1")));
            this.btn100.Appearance.Options.UseBackColor = true;
            this.btn100.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn100, "btn100");
            this.btn100.Name = "btn100";
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn200.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton9.Appearance.Font1")));
            this.btn200.Appearance.Options.UseBackColor = true;
            this.btn200.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn200, "btn200");
            this.btn200.Name = "btn200";
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // tbxSaled
            // 
            resources.ApplyResources(this.tbxSaled, "tbxSaled");
            this.tbxSaled.Name = "tbxSaled";
            // 
            // tbxChange
            // 
            resources.ApplyResources(this.tbxChange, "tbxChange");
            this.tbxChange.Name = "tbxChange";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl4.Appearance.Font")));
            this.labelControl4.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnBack.Appearance.Font")));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBack.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font6")));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.btnOtherProduct_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.simpleButton2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font2")));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.btnSaled_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font2")));
            this.btnClearAll.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnClearAll, "btnClearAll");
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnBack.Appearance.Font")));
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBack.ImageOptions.SvgImage")));
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SaleForm
            // 
            this.AcceptButton = this.btnAdd;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAmount);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSaled);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnOtherProduct);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnCashCard);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbxChange);
            this.Controls.Add(this.tbxSaled);
            this.Controls.Add(this.tbxSum);
            this.Controls.Add(this.tbxMoney);
            this.Controls.Add(this.cmbKamera);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbxBarcode);
            this.Controls.Add(this.tbxAmount);
            this.Controls.Add(this.dqw);
            this.Controls.Add(this.flp);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SaleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleForm_FormClosing);
            this.Load += new System.EventHandler(this.SaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.DataGridView dqw;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.TextBox tbxBarcode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.ComboBox cmbKamera;
        private System.Windows.Forms.TextBox tbxMoney;
        private DevExpress.XtraEditors.SimpleButton btn1;
        private DevExpress.XtraEditors.SimpleButton btn2;
        private DevExpress.XtraEditors.SimpleButton btn3;
        private DevExpress.XtraEditors.SimpleButton btn4;
        private DevExpress.XtraEditors.SimpleButton btn5;
        private DevExpress.XtraEditors.SimpleButton btn6;
        private DevExpress.XtraEditors.SimpleButton btn7;
        private DevExpress.XtraEditors.SimpleButton btn8;
        private DevExpress.XtraEditors.SimpleButton btn9;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btn0;
        private DevExpress.XtraEditors.SimpleButton btnComma;
        private DevExpress.XtraEditors.SimpleButton btnOtherProduct;
        private DevExpress.XtraEditors.SimpleButton btnBarcode;
        private DevExpress.XtraEditors.SimpleButton btnSaled;
        private DevExpress.XtraEditors.SimpleButton btnAmount;
        private DevExpress.XtraEditors.SimpleButton btnCash;
        private DevExpress.XtraEditors.SimpleButton btnCard;
        private DevExpress.XtraEditors.SimpleButton btnCashCard;
        private System.Windows.Forms.TextBox tbxSum;
        private DevExpress.XtraEditors.SimpleButton btn10;
        private DevExpress.XtraEditors.SimpleButton btn50;
        private DevExpress.XtraEditors.SimpleButton btn100;
        private DevExpress.XtraEditors.SimpleButton btn200;
        private System.Windows.Forms.TextBox tbxSaled;
        private System.Windows.Forms.TextBox tbxChange;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnClearAll;
        private DevExpress.XtraEditors.SimpleButton btnBack;
    }
}