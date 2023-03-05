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
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportForm()
        {
            InitializeComponent();
            _outcomeService = new OutcomeManager(new EfOutcomeDal());
            _ıncomeService = new IncomeManager(new EfIncomeDal());

        }
        public User user;
        IOutcomeService _outcomeService;
        IIncomeService _ıncomeService;

        private void ReportForm_Load(object sender, EventArgs e)
        {
            GetIncome();
            
        }

        private void GetOutcome()
        {
            dqw.DataSource = _outcomeService.GetAll();
        }

        private void GetIncome()
        {
            dqw.DataSource = _ıncomeService.GetAll();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            GetIncome();
        }

        private void btnOutcome_Click(object sender, EventArgs e)
        {
            GetOutcome();
        }

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
    }
}
