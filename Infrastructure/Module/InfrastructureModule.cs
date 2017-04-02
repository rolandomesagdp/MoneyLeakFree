using MoneyLeakFree.Infrastructure.Contracts;
using MoneyLeakFree.Infrastructure.Repositories;
using MoneyLeakFree.Infrastructure.UnitOfWork;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Infrastructure.Module
{
    public class InfrastructureModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<MoneyLeakFreeUnitOfWork>();
            Bind<IExpenseGroupRepository>().To<ExpenseGroupRepository>();
        }
    }
}
