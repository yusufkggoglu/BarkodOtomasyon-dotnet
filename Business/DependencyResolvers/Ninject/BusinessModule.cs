using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>();
            Bind<IProductDal>().To<EfProductDal>();

            Bind<IRoleService>().To<RoleManager>();
            Bind<IRoleDal>().To<EfRoleDal>();

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind<IIncomeService>().To<IncomeManager>();
            Bind<IIncomeDal>().To<EfIncomeDal>();

            Bind<IOutcomeService>().To<OutcomeManager>();
            Bind<IOutcomeDal>().To<EfOutcomeDal>();
        }
    }
}
