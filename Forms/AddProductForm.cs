using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using ZXing;
using AForge.Video.DirectShow;
using Business.DependencyResolvers.Ninject;

namespace Forms
{
    public partial class AddProductForm : DevExpress.XtraEditors.XtraForm
    {
        public AddProductForm()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _outcomeService = InstanceFactory.GetInstance<IOutgoingService>();
        }

        IOutgoingService _outcomeService;
        IProductService _productService;
        public User user;
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            tbxBarcode.Focus();
            GetCamera();
        }

        private void GetCamera()
        {
            try
            {
                Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo cihaz in Cihazlar)
                {
                    cmbKamera.Items.Add(cihaz.Name);
                }
                cmbKamera.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void LoadProducts()
        {
            dqwProducts.DataSource = _productService.GetAll();
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
                }
                ));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    Name = tbxProductName.Text,
                    Barcode = tbxBarcode.Text,
                    Discount = Convert.ToInt32(tbxDiscount.Text),
                    PurchasePrice = Convert.ToDecimal(tbxPurhasePrice.Text),
                    SalePrice = Convert.ToDecimal(tbxSalePrice.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmount.Text)
                });
                _outcomeService.Add(new Outgoing
                {
                    Date = DateTime.Now,
                    Amount = Convert.ToInt32(tbxStockAmount.Text),
                    Name = tbxProductName.Text,
                    PaymentMethod = "Güncellenecek",
                    UnitPrice = Convert.ToDecimal(tbxPurhasePrice.Text)
                });
                LoadProducts();
                DevExpress.XtraEditors.XtraMessageBox.Show("Ürün Girişi Yapıldı!");
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            CameraOff();
            StartCamera();
        }

        private void StartCamera()
        {
            try
            {
                kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);
                kameram.NewFrame += VideoCaptureDevice_NewFrame;
                kameram.Start();
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ID = Convert.ToInt32(dqwProducts.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün Silindi!");
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CameraOff();
        }

        private void CameraOff()
        {
            try
            {
                if (kameram != null)
                {
                    if (kameram.IsRunning)
                    {
                        kameram.Stop();
                    }
                }
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm()
            {
                user = user,
            };
            frm.Show();
            this.Hide();
            CameraOff();
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (BarcodeContext context = new BarcodeContext())
            {
                string aranan = textBox1.Text;
                var degerler = from item in context.Products where item.Name.Contains(aranan) select item;
                dqwProducts.DataSource = degerler.ToList();
            }
        }

        private void dqwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBarcode.Text = dqwProducts.CurrentRow.Cells[6].Value.ToString();
            tbxDiscount.Text = dqwProducts.CurrentRow.Cells[5].Value.ToString();
            tbxProductName.Text = dqwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxPurhasePrice.Text = dqwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxSalePrice.Text = dqwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxStockAmount.Text = dqwProducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product()
                {
                    ID = Convert.ToInt32(dqwProducts.CurrentRow.Cells[0].Value),
                    Barcode = Convert.ToString(tbxBarcode.Text),
                    Discount = Convert.ToInt32(tbxDiscount.Text),
                    Name = Convert.ToString(tbxProductName.Text),
                    PurchasePrice = Convert.ToDecimal(tbxPurhasePrice.Text),
                    SalePrice = Convert.ToDecimal(tbxSalePrice.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmount.Text)
                });
                //Product p = _productService.Get(Convert.ToInt32(dqwProducts.CurrentRow.Cells[0].Value));
                _outcomeService.Add(new Outgoing()
                {
                    Date = DateTime.Now,
                    Name = tbxProductName.Text,
                    PaymentMethod = "Güncellenecek",
                    Amount = Convert.ToInt32(tbxStockAmount.Text) - Convert.ToInt32(dqwProducts.CurrentRow.Cells[2].Value),
                    UnitPrice = Convert.ToDecimal(tbxPurhasePrice.Text)
                });
                LoadProducts();
                DevExpress.XtraEditors.XtraMessageBox.Show("Ürün Güncellendi!");
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }
    }
}