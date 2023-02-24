using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IIncomeService
    {
        List<Income> GetAll();
        void Add(Income ınCome);
        void Update(Income ınCome);
        void Delete(Income ınCome);
        Income Get(int id);
    }
}
