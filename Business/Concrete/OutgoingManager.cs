using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OutgoingManager:IOutgoingService
    {
        IOutgoingDal _outgoingDal;
        public OutgoingManager(IOutgoingDal outgoingDal)
        {
            _outgoingDal = outgoingDal;
        }

        public void Add(Outgoing outGoing)
        {
            ValidationTool.Validate(new OutgoingValidator(), outGoing);
            _outgoingDal.Add(outGoing);
        }

        public void Delete(Outgoing outGoing)
        {
            _outgoingDal.Delete(outGoing);
        }

        public Outgoing Get(int id)
        {
            return _outgoingDal.Get(p => p.ID.Equals(id));
        }

        public List<Outgoing> GetAll()
        {
            return _outgoingDal.GetAll();
        }

        public void Update(Outgoing outGoing)
        {
            ValidationTool.Validate(new OutgoingValidator(), outGoing);
            _outgoingDal.Update(outGoing);
        }
    }
}
