using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IExpenseGroupService
    {
        IEnumerable<ExpenseGroup> GetAll();

        ExpenseGroup GetById(Guid id);

        ExpenseGroup Add(ExpenseGroup expenseGroup);

        ExpenseGroup Edit(ExpenseGroup expenseGroup);

        void Delete(ExpenseGroup expenseGroup);
    }
}
