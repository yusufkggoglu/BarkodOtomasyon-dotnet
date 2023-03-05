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
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        public User user;

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        IncomeReportForm frm1;
        OutcomeReportForm frm2;

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
                frm1 = new IncomeReportForm();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
                frm2 = new OutcomeReportForm();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HomeForm frm = new HomeForm()
            {
                user = user
            };
            frm.Show();
            this.Hide();
            this.Dispose();
        }
    }
}
