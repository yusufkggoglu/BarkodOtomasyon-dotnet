using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Role { get; set; }
        public string Password { get; set; }
    }
}
