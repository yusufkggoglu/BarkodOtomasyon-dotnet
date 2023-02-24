using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOutcomeService
    {
        List<Outcome> GetAll();
        void Add(Outcome outCome);
        void Update(Outcome outCome);
        void Delete(Outcome outCome);
        Outcome Get(int id);
    }
}
