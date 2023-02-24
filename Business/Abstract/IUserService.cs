using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        User Get(int id);
    }
}
