using MoneyLeakFree.Business.Contracts;
using MoneyLeakFree.Business.Services;
using Ninject.Modules;

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
