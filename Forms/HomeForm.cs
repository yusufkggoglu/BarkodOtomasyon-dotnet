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
        }

        public User user;

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm frm = new AddProductForm()
            {
                user = user,
            };
            frm.Show();
            this.Hide();
        }
    }
}
