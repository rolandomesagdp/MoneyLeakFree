using Common.OperationResult;
using MoneyLeakFree.Web.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Web.Contracts
{
    public interface IExpenseGroupWorker
    {
        IEnumerable<ExpenseGroupDto> GetAll();

        OperationResult<ExpenseGroupDto> GetById(Guid id);

        OperationResult<ExpenseGroupDto> Edit(ExpenseGroupDto expenseGroupDto);

        OperationResult<ExpenseGroupDto> Create(ExpenseGroupDto expenseGroupDto);

        OperationResult<ExpenseGroupDto> Delete(Guid expenseGroupDto);
    }
}
