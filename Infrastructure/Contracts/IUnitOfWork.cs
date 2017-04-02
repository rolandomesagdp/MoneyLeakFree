using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Infrastructure.Contracts
{
    public interface IUnitOfWork
    {
        IExpenseGroupRepository ExpenseGroupRepository { get; }

        void SaveChanges();
    }
}
