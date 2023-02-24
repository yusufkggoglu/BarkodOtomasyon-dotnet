using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class IncomeManager:IIncomeService
    {
        IIncomeDal _ıncomeDal;
        public IncomeManager(IIncomeDal ıncomeDal) 
        {
            _ıncomeDal = ıncomeDal;
        }

        public void Add(Income ınCome)
        {
            _ıncomeDal.Add(ınCome);
        }

        public void Delete(Income ınCome)
        {
            _ıncomeDal.Delete(ınCome);
        }

        public Income Get(int id)
        {
            return _ıncomeDal.Get(p => p.ID.Equals(id));
        }

        public List<Income> GetAll()
        {
            return _ıncomeDal.GetAll();
        }

        public void Update(Income ınCome)
        {
            _ıncomeDal.Update(ınCome);
        }
    }
}
