using Infrastructure.Contracts;
using Infrastructure.InfrastructureContext;
using Infrastructure.Repositories;
using Infrastructure.UnitOfWork;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Module
{
    public class InfrastructureModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<MoneyLeakFreeUnitOfWork>();
            Bind<IExpenseGroupRepository>().To<ExpenseGroupRepository>();
            //Bind<MoneyLeakFreeDbContext>().ToSelf();
        }
    }
}
