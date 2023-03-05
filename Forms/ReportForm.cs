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
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportForm()
        {
            InitializeComponent();
            _ıncomeService = InstanceFactory.GetInstance<IIncomeService>();
            _outcomeService = InstanceFactory.GetInstance<IOutcomeService>();
        }

        IIncomeService _ıncomeService;
        IOutcomeService _outcomeService;
        public User user;
        IncomeReportForm frm1;
        OutcomeReportForm frm2;

        private void ReportForm_Load(object sender, EventArgs e)
        {
            CalculateGain();
        }

        private void CalculateGain()
        {
            decimal income = 0;
            decimal outcome = 0;
            var incomelist = _ıncomeService.GetAll();
            var outcomelist = _outcomeService.GetAll();
            foreach (var temp in incomelist)
            {
                income += Convert.ToDecimal(temp.Amount * temp.UnitPrice);
            }
            foreach (var temp in outcomelist)
            {
                outcome += Convert.ToDecimal(temp.Amount * temp.UnitPrice);
            }
            tbxGain.Text = Convert.ToDecimal(income - outcome).ToString();
        }

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CalculateGain();
        }
    }
}
