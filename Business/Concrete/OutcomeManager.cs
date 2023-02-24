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
    public class OutcomeManager:IOutcomeService
    {
        IOutcomeDal _outcomeDal;
        public OutcomeManager(IOutcomeDal outcomeDal)
        {
            _outcomeDal = outcomeDal;
        }

        public void Add(Outcome outCome)
        {
            _outcomeDal.Add(outCome);
        }

        public void Delete(Outcome outCome)
        {
            _outcomeDal.Delete(outCome);
        }

        public Outcome Get(int id)
        {
            return _outcomeDal.Get(p => p.ID.Equals(id));
        }

        public List<Outcome> GetAll()
        {
            return _outcomeDal.GetAll();
        }

        public void Update(Outcome outCome)
        {
            _outcomeDal.Update(outCome);
        }
    }
}
