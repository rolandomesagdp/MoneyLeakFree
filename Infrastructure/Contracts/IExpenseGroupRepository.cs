using MoneyLeakFree.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Infrastructure.Contracts
{
    public interface IExpenseGroupRepository : IRepository<ExpenseGroup>
    {
        IEnumerable<ExpenseGroup> GetAllForUser(Guid userId);
    }
}
