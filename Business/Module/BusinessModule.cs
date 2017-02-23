using Business.Contracts;
using Business.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Module
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IExpenseGroupService>().To<ExpenseGroupService>();
            Bind<IMovementService>().To<MovementService>();
        }
    }
}
