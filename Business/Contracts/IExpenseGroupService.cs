using Common.OperationResult;
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

        OperationResult<ExpenseGroup> GetById(Guid id);

        OperationResult<ExpenseGroup> Add(ExpenseGroup expenseGroup);

        OperationResult<ExpenseGroup> Edit(ExpenseGroup expenseGroup);

        OperationResult<ExpenseGroup> Delete(Guid id);
    }
}
