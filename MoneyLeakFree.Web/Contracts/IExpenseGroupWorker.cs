using MoneyLeakFree.Common.OperationResult;
using MoneyLeakFree.Web.DTO;
using System;
using System.Collections.Generic;

namespace MoneyLeakFree.Web.Contracts
{
    public interface IExpenseGroupWorker
    {
        IEnumerable<ExpenseGroupDto> GetAllForUser(Guid userId);

        OperationResult<ExpenseGroupDto> GetById(Guid id);

        OperationResult<ExpenseGroupDto> Edit(ExpenseGroupDto expenseGroupDto);

        OperationResult<ExpenseGroupDto> Create(ExpenseGroupDto expenseGroupDto);

        OperationResult<ExpenseGroupDto> Delete(Guid expenseGroupDto);
    }
}
