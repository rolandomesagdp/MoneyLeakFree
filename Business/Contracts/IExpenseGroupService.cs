using MoneyLeakFree.Common.OperationResult;
using MoneyLeakFree.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MoneyLeakFree.Business.Contracts
{
    public interface IExpenseGroupService
    {
        IEnumerable<ExpenseGroup> GetAllForuser(Guid userId);

        OperationResult<ExpenseGroup> GetById(Guid id);

        OperationResult<ExpenseGroup> Add(ExpenseGroup expenseGroup);

        OperationResult<ExpenseGroup> Edit(ExpenseGroup expenseGroup);

        OperationResult<ExpenseGroup> Delete(Guid id);
    }
}
