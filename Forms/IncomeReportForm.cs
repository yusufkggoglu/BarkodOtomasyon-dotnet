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
using Excel = Microsoft.Office.Interop.Excel;

namespace Forms
{
    public partial class IncomeReportForm : DevExpress.XtraEditors.XtraForm
    {
        public IncomeReportForm()
        {
            InitializeComponent();
            _ıncomeService = new IncomeManager(new EfIncomeDal());
        }

        IIncomeService _ıncomeService;

        private void IncomeReportForm_Load(object sender, EventArgs e)
        {
            LoadIncome();
            GetSum();
        }

        private void GetSum()
        {
            decimal sum = 0;
            var list = _ıncomeService.GetAll();
            foreach (var temp in list)
            {
                sum += Convert.ToDecimal(temp.Amount) * Convert.ToDecimal(temp.UnitPrice);
            }
            tbxSum.Text = sum.ToString();
        }

        private void LoadIncome()
        {
            dqw.DataSource = _ıncomeService.GetAll();
        }

        private void dqw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dqw.CurrentRow.Cells[1].Value.ToString();
            tbxAmount.Text = dqw.CurrentRow.Cells[2].Value.ToString();
            tbxUnitPrice.Text= dqw.CurrentRow.Cells[3].Value.ToString();
            tbxPaymentMethod.Text= dqw.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ıncomeService.Add(new Income()
            {
                Name = tbxName.Text,
                Amount = Convert.ToInt32(tbxAmount.Text),
                Date= DateTime.Now,
                PaymentMethod = tbxPaymentMethod.Text,
                UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text)
            });
            LoadIncome();
            GetSum();
            DevExpress.XtraEditors.XtraMessageBox.Show("Gelir Eklendi !");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _ıncomeService.Update(new Income()
            {
                ID = Convert.ToInt32(dqw.CurrentRow.Cells[0].Value),
                Name = tbxName.Text,
                Amount = Convert.ToInt32(tbxAmount.Text),
                Date = DateTime.Now,
                PaymentMethod = tbxPaymentMethod.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
            });
            LoadIncome();
            GetSum();
            DevExpress.XtraEditors.XtraMessageBox.Show("Gelir Güncellendi !");
        }
        //düzenlenecek
        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            using(BarcodeContext db = new BarcodeContext())
            {
                var result = db.Incomes.Where(x => x.Date > dtpStart.MaxDate &&  x.Date < dtpFinish.MaxDate);
                dqw.DataSource = result.ToList();
            }
        }

        bool export_dgw_excel_1(DataGridView dgw)
        {
            bool durum = false;
            try
            {
                dgw.SelectAll();
                DataObject dataObj = dgw.GetClipboardContent();
                if (dataObj != null)
                    Clipboard.SetDataObject(dataObj);
                Excel.Application xlexcel;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                durum = true;
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Veriler Aktarılamadı : " + exception.Message);
            }
            return durum;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            export_dgw_excel_1(dqw);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            DialogResult secenek = DevExpress.XtraEditors.XtraMessageBox.Show("Gelir geçmişi silinecek, Emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                var list = _ıncomeService.GetAll();
                foreach (var temp in list)
                {
                    _ıncomeService.Delete(temp);
                }
                LoadIncome();
            }
        }
    }
}
