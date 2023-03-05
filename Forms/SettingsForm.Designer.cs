namespace Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.dqwRoles = new System.Windows.Forms.DataGridView();
            this.dqwUsers = new System.Windows.Forms.DataGridView();
            this.tbxRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleName = new DevExpress.XtraEditors.LabelControl();
            this.btnRoleAdd = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.cmbAdminStatus = new System.Windows.Forms.ComboBox();
            this.btnRoleUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnRoleDelete = new DevExpress.XtraEditors.SimpleButton();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new DevExpress.XtraEditors.LabelControl();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.btnUserDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnUserAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dqwRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dqwUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dqwRoles
            // 
            this.dqwRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dqwRoles, "dqwRoles");
            this.dqwRoles.Name = "dqwRoles";
            this.dqwRoles.RowTemplate.Height = 24;
            this.dqwRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwRoles_CellClick);
            // 
            // dqwUsers
            // 
            this.dqwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dqwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dqwUsers, "dqwUsers");
            this.dqwUsers.Name = "dqwUsers";
            this.dqwUsers.RowTemplate.Height = 24;
            this.dqwUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dqwUsers_CellClick);
            // 
            // tbxRoleName
            // 
            resources.ApplyResources(this.tbxRoleName, "tbxRoleName");
            this.tbxRoleName.Name = "tbxRoleName";
            // 
            // lblRoleName
            // 
            this.lblRoleName.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblRoleName.Appearance.Font")));
            this.lblRoleName.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblRoleName, "lblRoleName");
            this.lblRoleName.Name = "lblRoleName";
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnRoleAdd.Appearance.Font")));
            this.btnRoleAdd.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnRoleAdd, "btnRoleAdd");
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Click += new System.EventHandler(this.btnRoleAdd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblStatus.Appearance.Font")));
            this.lblStatus.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // cmbAdminStatus
            // 
            resources.ApplyResources(this.cmbAdminStatus, "cmbAdminStatus");
            this.cmbAdminStatus.FormattingEnabled = true;
            this.cmbAdminStatus.Items.AddRange(new object[] {
            resources.GetString("cmbAdminStatus.Items"),
            resources.GetString("cmbAdminStatus.Items1")});
            this.cmbAdminStatus.Name = "cmbAdminStatus";
            // 
            // btnRoleUpdate
            // 
            this.btnRoleUpdate.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnRoleUpdate.Appearance.Font")));
            this.btnRoleUpdate.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnRoleUpdate, "btnRoleUpdate");
            this.btnRoleUpdate.Name = "btnRoleUpdate";
            this.btnRoleUpdate.Click += new System.EventHandler(this.btnRoleUpdate_Click);
            // 
            // btnRoleDelete
            // 
            this.btnRoleDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnRoleDelete.Appearance.Font")));
            this.btnRoleDelete.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnRoleDelete, "btnRoleDelete");
            this.btnRoleDelete.Name = "btnRoleDelete";
            this.btnRoleDelete.Click += new System.EventHandler(this.btnRoleDelete_Click);
            // 
            // tbxUserName
            // 
            resources.ApplyResources(this.tbxUserName, "tbxUserName");
            this.tbxUserName.Name = "tbxUserName";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblName.Appearance.Font")));
            this.lblName.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // cmbRole
            // 
            resources.ApplyResources(this.cmbRole, "cmbRole");
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            resources.GetString("cmbRole.Items"),
            resources.GetString("cmbRole.Items1")});
            this.cmbRole.Name = "cmbRole";
            // 
            // lblRole
            // 
            this.lblRole.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblRole.Appearance.Font")));
            this.lblRole.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblRole, "lblRole");
            this.lblRole.Name = "lblRole";
            // 
            // tbxPassword
            // 
            resources.ApplyResources(this.tbxPassword, "tbxPassword");
            this.tbxPassword.Name = "tbxPassword";
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lblPassword.Appearance.Font")));
            this.lblPassword.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnUserDelete.Appearance.Font")));
            this.btnUserDelete.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnUserDelete, "btnUserDelete");
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnUserUpdate.Appearance.Font")));
            this.btnUserUpdate.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnUserUpdate, "btnUserUpdate");
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnUserAdd.Appearance.Font")));
            this.btnUserAdd.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnUserAdd, "btnUserAdd");
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tbxRoleName);
            this.groupControl1.Controls.Add(this.lblRoleName);
            this.groupControl1.Controls.Add(this.btnRoleAdd);
            this.groupControl1.Controls.Add(this.btnRoleDelete);
            this.groupControl1.Controls.Add(this.lblStatus);
            this.groupControl1.Controls.Add(this.btnRoleUpdate);
            this.groupControl1.Controls.Add(this.cmbAdminStatus);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblName);
            this.groupControl2.Controls.Add(this.tbxUserName);
            this.groupControl2.Controls.Add(this.lblRole);
            this.groupControl2.Controls.Add(this.btnUserDelete);
            this.groupControl2.Controls.Add(this.cmbRole);
            this.groupControl2.Controls.Add(this.btnUserUpdate);
            this.groupControl2.Controls.Add(this.lblPassword);
            this.groupControl2.Controls.Add(this.btnUserAdd);
            this.groupControl2.Controls.Add(this.tbxPassword);
            resources.ApplyResources(this.groupControl2, "groupControl2");
            this.groupControl2.Name = "groupControl2";
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dqwUsers);
            this.Controls.Add(this.dqwRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dqwRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dqwUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dqwRoles;
        private System.Windows.Forms.DataGridView dqwUsers;
        private System.Windows.Forms.TextBox tbxRoleName;
        private DevExpress.XtraEditors.LabelControl lblRoleName;
        private DevExpress.XtraEditors.SimpleButton btnRoleAdd;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private System.Windows.Forms.ComboBox cmbAdminStatus;
        private DevExpress.XtraEditors.SimpleButton btnRoleUpdate;
        private DevExpress.XtraEditors.SimpleButton btnRoleDelete;
        private System.Windows.Forms.TextBox tbxUserName;
        private DevExpress.XtraEditors.LabelControl lblName;
        private System.Windows.Forms.ComboBox cmbRole;
        private DevExpress.XtraEditors.LabelControl lblRole;
        private System.Windows.Forms.TextBox tbxPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.SimpleButton btnUserDelete;
        private DevExpress.XtraEditors.SimpleButton btnUserUpdate;
        private DevExpress.XtraEditors.SimpleButton btnUserAdd;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}