using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }
        IUserService _userService;
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "4";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxPassword.Text += "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbxPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var list = _userService.GetAll();
                foreach (var temp in list)
                {
                    if (temp.Password == tbxPassword.Text)
                    {
                        HomeForm frm1 = new HomeForm()
                        {
                            user = temp,
                        };
                        frm1.Show();
                        this.Hide();
                    }
                }
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bir sorun oluştu , Tekrar deneyiniz !");
            }
        }
    }
}
