using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _roleService = InstanceFactory.GetInstance<IRoleService>();
        }

        IRoleService _roleService;
        IUserService _userService;
        public User user;

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm()
            {
                user = user
            };
            frm.Show();
            this.Hide();
            this.Dispose();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            GetRoles();
            LoadRole();
            LoadUser();
        }

        private void GetRoles()
        {
            cmbRole.DataSource = _roleService.GetAll();
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "ID";
        }

        private void LoadUser()
        {
            dqwUsers.DataSource = _userService.GetAll();
        }

        private void LoadRole()
        {
            dqwRoles.DataSource = _roleService.GetAll();
        }

        private void dqwRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxRoleName.Text= dqwRoles.CurrentRow.Cells[1].Value.ToString();
            cmbAdminStatus.SelectedIndex = Convert.ToInt32(dqwRoles.CurrentRow.Cells[2].Value);
        }

        private void dqwUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUserName.Text = dqwUsers.CurrentRow.Cells[1].Value.ToString();
            cmbRole.SelectedValue = dqwUsers.CurrentRow.Cells[2].Value;
            tbxPassword.Text = dqwUsers.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            _roleService.Add(new Role()
            {
                Name = tbxRoleName.Text,
                AdminStatus = cmbAdminStatus.SelectedIndex.ToString(),
            });
            LoadRole();
            GetRoles();
        }

        private void btnRoleUpdate_Click(object sender, EventArgs e)
        {
            _roleService.Update(new Role()
            {
                ID = Convert.ToInt32(dqwRoles.CurrentRow.Cells[0].Value),
                Name = tbxRoleName.Text,
                AdminStatus = cmbAdminStatus.SelectedIndex.ToString(),
            });
            LoadRole();
            GetRoles();
        }

        private void btnRoleDelete_Click(object sender, EventArgs e)
        {
            _roleService.Delete(new Role()
            {
                ID = Convert.ToInt32(dqwRoles.CurrentRow.Cells[0].Value)
            });
            LoadRole();
            GetRoles();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            _userService.Add(new User()
            {
                Name = tbxUserName.Text,
                Password= tbxPassword.Text,
                Role = Convert.ToInt32(cmbRole.SelectedValue)
            });
            LoadUser();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            _userService.Update(new User()
            {
                ID = Convert.ToInt32(dqwUsers.CurrentRow.Cells[0].Value),
                Name = tbxUserName.Text,
                Password = tbxPassword.Text,
                Role = Convert.ToInt32(cmbRole.SelectedValue)
            });
            LoadUser();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            _userService.Delete(new User()
            {
                ID = Convert.ToInt32(dqwUsers.CurrentRow.Cells[0].Value)
            });
            LoadUser();
        }
    }
}
