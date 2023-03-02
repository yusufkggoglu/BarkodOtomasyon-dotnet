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
    public partial class StockForm : DevExpress.XtraEditors.XtraForm
    {
        public StockForm()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }
        IProductService _productService;
        public User user;
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            using (BarcodeContext context = new BarcodeContext())
            {
                string aranan = tbxSearch.Text;
                var degerler = from item in context.Products where item.Name.Contains(aranan) select item;
                dqwProducts.DataSource = degerler.ToList();
            }
        }
        private void LoadProducts()
        {
            dqwProducts.DataSource = _productService.GetAll();
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm frm = new HomeForm()
            {
                user = user,
            };
            frm.Show();
            this.Hide();
        }
    }
}
