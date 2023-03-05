using AForge.Video.DirectShow;
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
using ZXing;

namespace Forms
{
    public partial class SaleForm : DevExpress.XtraEditors.XtraForm
    {
        public SaleForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _ıncomeService = InstanceFactory.GetInstance<IIncomeService>();
        }

        IProductService _productService;
        IIncomeService _ıncomeService;
        public User user;
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;

        private void SaleForm_Load(object sender, EventArgs e)
        {
            CreateDataGridView();
            GetProducts();
            tbxBarcode.Focus();
            GetCamera();
            StartCamera();
        }

        private void StartCamera()
        {
            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);
            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }

        private void GetCamera()
        {
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);
            }
            cmbKamera.SelectedIndex = 0;
        }

        private void CreateDataGridView()
        {
            dqw.ColumnCount = 3;
            dqw.Columns[0].Name = "Ürün";
            dqw.Columns[1].Name = "Miktar";
            dqw.Columns[2].Name = "Fiyat";
        }
        
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap GoruntulenenBarkod = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader okuyucu = new BarcodeReader();
            var sonuc = okuyucu.Decode(GoruntulenenBarkod);

            if (sonuc != null)
            {
                tbxBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    tbxBarcode.Text = sonuc.ToString();
                }));
            }
        }

        private void newOrderBarcode()
        {
            try
            {
                Product p = _productService.GetBarcode(tbxBarcode.Text);
                dqw.Rows.Add(p.Name,Convert.ToInt32(tbxAmount.Text), p.SalePrice);
            }
            catch 
            {
                MessageBox.Show("Barkod okunamadı !");
            }
        }

        private void newOrderOtherProducts()
        {
            dqw.Rows.Add("Diğer Ürün", Convert.ToInt32(tbxAmount.Text), Convert.ToDecimal(tbxMoney.Text));
            LoadPrice();
        }

        public void GetProducts()
        {
            var model = _productService.GetAll();
            for (int i = 0; i < model.Count; i++)
            {
                DevExpress.XtraEditors.SimpleButton btn = new DevExpress.XtraEditors.SimpleButton();
                btn.Text = model[i].Name+Environment.NewLine+model[i].SalePrice;
                btn.Font = new Font("Microsoft Sans Serif", 10);
                btn.Name = model[i].Name.ToString();
                btn.Height = 75;
                btn.Width = 100;
                btn.AccessibleDescription = model[i].SalePrice.ToString();
                btn.Appearance.BackColor = Color.White;
                flp.Controls.Add(btn);
                btn.Click += newOrderBtn;
            }
        }

        public void newOrderBtn(object sender, System.EventArgs e)
        {
            try
            {
                DevExpress.XtraEditors.SimpleButton btn = sender as DevExpress.XtraEditors.SimpleButton;
                dqw.Rows.Add(btn.Name,Convert.ToInt32(tbxAmount.Text), btn.AccessibleDescription);
                LoadPrice();
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newOrderBarcode();
            LoadPrice();
        }

        private void CameraOff()
        {
            if (kameram != null)
            {
                if (kameram.IsRunning)
                {
                    kameram.Stop();
                }
            }
        }

        private void SaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CameraOff();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "1";
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

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxMoney.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += "0";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (tbxMoney.Text == "0")
            {
                tbxMoney.Text = "";
            }
            tbxMoney.Text += ",";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            decimal var = Convert.ToDecimal(tbxMoney.Text);
            var += 10;
            tbxMoney.Text = var.ToString();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            decimal var = Convert.ToDecimal(tbxMoney.Text);
            var += 50;
            tbxMoney.Text = var.ToString();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            decimal var = Convert.ToDecimal(tbxMoney.Text);
            var += 100;
            tbxMoney.Text = var.ToString();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            decimal var = Convert.ToDecimal(tbxMoney.Text);
            var += 200;
            tbxMoney.Text = var.ToString();
        }

        private void btnOtherProduct_Click(object sender, EventArgs e)
        {
            newOrderOtherProducts();
        }

        private void btnAmount_Click(object sender, EventArgs e)
        {
            tbxAmount.Text = "";
            tbxAmount.Text = tbxMoney.Text;
        }

        private void btnBarcode_Click(object sender, EventArgs e)
        {
            tbxBarcode.Text = tbxMoney.Text;
        }

        private void LoadPrice()
        {
            decimal toplam = 0;
            for (int i = 0; i < dqw.Rows.Count; ++i)
            {
                toplam += Convert.ToDecimal(dqw.Rows[i].Cells[2].Value);
            }
            tbxSum.Text = toplam.ToString();
        }

        private void btnSaled_Click(object sender, EventArgs e)
        {
            tbxSaled.Text = tbxMoney.Text;
            tbxChange.Text = (Convert.ToDecimal(tbxSaled.Text) - Convert.ToDecimal(tbxSum.Text)).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = dqw.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dqw.Rows.RemoveAt(selectedIndex);
                dqw.Refresh();
            }
            LoadPrice();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            dqw.Rows.Clear();
            tbxSaled.Text = "0";
            tbxAmount.Text = "1";
            tbxBarcode.Text = "";
            tbxChange.Text = "0";
            tbxMoney.Text = "0";
            tbxSum.Text = "0";
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Product p;
            decimal sum = 0;
            for (int i = 0; i < dqw.Rows.Count - 1; i++)
            {
                p = _productService.GetByName(dqw.Rows[i].Cells[0].Value.ToString());
                if (p != null)
                {
                    int amount = p.StockAmount - Convert.ToInt32(dqw.Rows[i].Cells[1].Value);
                    _productService.Update(new Product()
                    {
                        ID = p.ID,
                        Name = p.Name,
                        Discount = p.Discount,
                        PurchasePrice = p.PurchasePrice,
                        SalePrice = p.SalePrice,
                        Barcode = p.Barcode,
                        StockAmount = amount,
                    });
                }
                sum += Convert.ToDecimal(dqw.Rows[i].Cells[2].Value);
            }
            ClearAll();
            _ıncomeService.Add(new Income()
            {
                Name = "Satış",
                Date = DateTime.Now,
                Amount = 1,
                UnitPrice = sum,
                PaymentMethod = "Nakit"
            });
            DevExpress.XtraEditors.XtraMessageBox.Show("Satış Yapıldı !");
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Product p;
            decimal sum = 0;
            for (int i = 0; i < dqw.Rows.Count - 1; i++)
            {
                p = _productService.GetByName(dqw.Rows[i].Cells[0].Value.ToString());
                if (p != null)
                {
                    int amount = p.StockAmount - Convert.ToInt32(dqw.Rows[i].Cells[1].Value);
                    _productService.Update(new Product()
                    {
                        ID = p.ID,
                        Name = p.Name,
                        Discount = p.Discount,
                        PurchasePrice = p.PurchasePrice,
                        SalePrice = p.SalePrice,
                        Barcode = p.Barcode,
                        StockAmount = amount,
                    });
                }
                sum += Convert.ToDecimal(dqw.Rows[i].Cells[2].Value);
            }
            ClearAll();
            _ıncomeService.Add(new Income()
            {
                Name = "Satış",
                Date = DateTime.Now,
                Amount = 1,
                UnitPrice = sum,
                PaymentMethod="Kredi Kartı" 
            });
            DevExpress.XtraEditors.XtraMessageBox.Show("Satış Yapıldı !");
        }

        private void cmbKamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            CameraOff();
            StartCamera();
        }
    }
}
