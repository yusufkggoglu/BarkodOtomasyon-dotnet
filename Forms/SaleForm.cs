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
    public partial class SaleForm : DevExpress.XtraEditors.XtraForm
    {
        public SaleForm()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        IProductService _productService;
        FilterInfoCollection Cihazlar;
        VideoCaptureDevice kameram;
        private void SaleForm_Load(object sender, EventArgs e)
        {
            dqw.ColumnCount = 3;
            dqw.Columns[0].Name = "Ürün";
            dqw.Columns[1].Name = "Miktar";
            dqw.Columns[2].Name = "Fiyat";

            GetProducts();

            tbxBarcode.Focus();
            Cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //FilterInfo cihazdaki görüntü yakalama cihazları hakkında bilgi tutar.
            foreach (FilterInfo cihaz in Cihazlar)
            {
                cmbKamera.Items.Add(cihaz.Name);
            }
            //İlk bulduğu kamera ismi görünsün diye ilk atamayı yaptık, 0 verdik.
            cmbKamera.SelectedIndex = 0;

            kameram = new VideoCaptureDevice(Cihazlar[cmbKamera.SelectedIndex].MonikerString);

            kameram.NewFrame += VideoCaptureDevice_NewFrame;
            kameram.Start();
        }
        //FilterInfoCollection ve VideoCaptureDevice sınıfından nesnelerimi türettim. FilterInfoCollection cihazımdaki tüm kameraları, yakalama cihazlarını vs bulur. VideoCaptureDevice ise benim kullanacağım kamera için değişkenim olacak.
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
        private void newOrderBarcode()
        {
            Product p = _productService.GetBarcode(tbxBarcode.Text);
            dqw.Rows.Add(p.Name, 1, p.SalePrice);
        }

        public void GetProducts()
        {
            var model = _productService.GetAll();
            for (int i = 0; i < model.Count; i++)
            {
                DevExpress.XtraEditors.SimpleButton btn = new DevExpress.XtraEditors.SimpleButton();
                btn.Text = model[i].Name+Environment.NewLine+model[i].SalePrice;
                btn.Font = new Font("Microsoft Sans Serif", 15);
                btn.Name = model[i].Name.ToString();
                btn.Height = 125;
                btn.Width = 125;
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
                dqw.Rows.Add(btn.Name, 1, btn.AccessibleDescription);
            }
            catch (Exception exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(exception.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            newOrderBarcode();
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
    }
}
