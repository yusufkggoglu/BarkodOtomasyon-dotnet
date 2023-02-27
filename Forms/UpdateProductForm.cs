using AForge.Video.DirectShow;
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
using ZXing;

namespace Forms
{
    public partial class UpdateProductForm : DevExpress.XtraEditors.XtraForm
    {
        public UpdateProductForm()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        IProductService _productService;
        public User user;
        private void dqwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBarcode.Text = dqwProducts.CurrentRow.Cells[6].Value.ToString();
            tbxDiscount.Text = dqwProducts.CurrentRow.Cells[5].Value.ToString();
            tbxProductName.Text = dqwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxPurhasePrice.Text = dqwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxSalePrice.Text = dqwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxStockAmount.Text = dqwProducts.CurrentRow.Cells[2].Value.ToString();
        }

        private void LoadProducts()
        {
            dqwProducts.DataSource = _productService.GetAll();
        }
        //FilterInfoCollection ve VideoCaptureDevice sınıfından nesnelerimi türettim. FilterInfoCollection cihazımdaki tüm kameraları, yakalama cihazlarını vs bulur. VideoCaptureDevice ise benim kullanacağım kamera için değişkenim olacak.
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;


        //Kamerayı başlatmak için yazılan kodlar. NewFrame Her bir görüntü için yeni bir frame başlatır. 
        private void btnBasla_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);

            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }


        //Kullanılan cihazın metodunu oluşturuyorum
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

        //Form kapatma esnasında da kamera durdurma işlemim.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kameram != null)
            {
                if (kameram.IsRunning)
                {
                    kameram.Stop();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
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
            LoadProducts();
            DevExpress.XtraEditors.XtraMessageBox.Show("Ürün Güncellendi!");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);

            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }

        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            tbxBarcode.Focus();

            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //FilterInfo cihazdaki görüntü yakalama cihazları hakkında bilgi tutar.
            foreach (FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);
            }
            //İlk bulduğu kamera ismi görünsün diye ilk atamayı yaptık, 0 verdik.
            cmbKamera.SelectedIndex = 0;
        }
    }
}
