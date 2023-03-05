using Business.Abstract;
using Business.Concrete;
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
    public partial class HomeForm : DevExpress.XtraEditors.XtraForm
    {
        public HomeForm()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }
        IUserService _userService;
        public User user;
        private void HomeForm_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Kullanıcı : " + user.Name;
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm frm = new AddProductForm()
            {
                user = user,
            };
            frm.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleForm frm = new SaleForm()
            {
                user = user,
            };
            frm.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            StockForm frm = new StockForm()
            {
                user = user,
            };
            frm.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm()
            {
                user = user
            };
            frm.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
