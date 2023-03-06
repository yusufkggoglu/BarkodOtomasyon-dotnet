using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOutgoingService
    {
        List<Outgoing> GetAll();
        void Add(Outgoing outGoing);
        void Update(Outgoing outGoing);
        void Delete(Outgoing outGoing);
        Outgoing Get(int id);
    }
}
