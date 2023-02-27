using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StockAmount { get; set; }
        public decimal  PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Discount { get; set; }
        public string Barcode { get; set; }
    }
}
