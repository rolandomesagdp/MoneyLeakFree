using MoneyLeakFree.Web.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoneyLeakFree.Web.DTO;
using Business.Contracts;

namespace MoneyLeakFree.Web.Workers
{
    public class ExpenseGroupWorker : IExpenseGroupWorker
    {
        private readonly IExpenseGroupService expenseGroupService;

        public ExpenseGroupWorker(IExpenseGroupService expenseGroupService)
        {
            this.expenseGroupService = expenseGroupService;
        }

        public IEnumerable<ExpenseGroupDto> GetAll()
        {
            var expenceGroupDtosToReturn = new List<ExpenseGroupDto>();

            var expenseGroups = this.expenseGroupService.GetAll();

            foreach (var expenseGroup in expenseGroups)
            {
                var expenseGroupDto = new ExpenseGroupDto()
                {
                    Id = Guid.Parse(expenseGroup.Id),
                    Name = expenseGroup.Name,
                    Active = expenseGroup.Active,
                    CreationDate = expenseGroup.CreationDate,
                    LastUpdateDate = expenseGroup.LastUpdateDate
                };

                expenceGroupDtosToReturn.Add(expenseGroupDto);
            }

            return expenceGroupDtosToReturn;
        }
    }
}