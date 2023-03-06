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
    public class UserManager:IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Add(user);
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public User Get(int id)
        {
            return _userDal.Get(p => p.ID.Equals(id));
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Update(User user)
        {
            ValidationTool.Validate(new UserValidator(), user);
            _userDal.Update(user);
        }
    }
}
