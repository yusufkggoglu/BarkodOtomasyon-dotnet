using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Outcome:IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int UnitPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
