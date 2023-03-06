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
using Excel = Microsoft.Office.Interop.Excel;

namespace Forms
{
    public partial class OutgoingReportForm : DevExpress.XtraEditors.XtraForm
    {
        public OutgoingReportForm()
        {
            InitializeComponent();
            _outgoingService = InstanceFactory.GetInstance<IOutgoingService>();
        }

        IOutgoingService _outgoingService;
        
        private void GetSum()
        {
            decimal sum = 0;
            var list = _outgoingService.GetAll();
            foreach (var temp in list)
            {
                sum += Convert.ToDecimal(temp.Amount) * Convert.ToDecimal(temp.UnitPrice);
            }
            tbxSum.Text = sum.ToString();
        }

        private void LoadOutgoing()
        {
            dqw.DataSource = _outgoingService.GetAll();
        }

        private void dqw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dqw.CurrentRow.Cells[1].Value.ToString();
            tbxAmount.Text = dqw.CurrentRow.Cells[2].Value.ToString();
            tbxUnitPrice.Text = dqw.CurrentRow.Cells[3].Value.ToString();
            tbxPaymentMethod.Text = dqw.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _outgoingService.Add(new Outgoing()
                {
                    Name = tbxName.Text,
                    Amount = Convert.ToInt32(tbxAmount.Text),
                    Date = DateTime.Now,
                    PaymentMethod = tbxPaymentMethod.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
                });
                LoadOutgoing();
                GetSum();
                DevExpress.XtraEditors.XtraMessageBox.Show("Gider Eklendi !");
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _outgoingService.Update(new Outgoing()
                {
                    ID = Convert.ToInt32(dqw.CurrentRow.Cells[0].Value),
                    Name = tbxName.Text,
                    Amount = Convert.ToInt32(tbxAmount.Text),
                    Date = DateTime.Now,
                    PaymentMethod = tbxPaymentMethod.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
                });
                LoadOutgoing();
                GetSum();
                DevExpress.XtraEditors.XtraMessageBox.Show("Gider Güncellendi !");
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        //düzenlenecek
        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            using (BarcodeContext db = new BarcodeContext())
            {
                var result = db.Incomes.Where(x => x.Date > dtpStart.MaxDate && x.Date < dtpFinish.MaxDate);
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
            DialogResult secenek = DevExpress.XtraEditors.XtraMessageBox.Show("Gider geçmişi silinecek, Emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                var list = _outgoingService.GetAll();
                foreach (var temp in list)
                {
                    _outgoingService.Delete(temp);
                }
                LoadOutgoing();
            }
        }

        private void OutcomeReportForm_Load(object sender, EventArgs e)
        {
            LoadOutgoing();
            GetSum();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _outgoingService.Delete(new Outgoing()
            {
                ID = Convert.ToInt32(dqw.CurrentRow.Cells[0].Value),
            });
            LoadOutgoing();
            DevExpress.XtraEditors.XtraMessageBox.Show("Gider silindi !");
        }
     }
}
