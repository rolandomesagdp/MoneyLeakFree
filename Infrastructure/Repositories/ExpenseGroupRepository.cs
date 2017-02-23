using Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using System.Linq.Expressions;
using Infrastructure.InfrastructureContext;

namespace Infrastructure.Repositories
{
    public class ExpenseGroupRepository : IExpenseGroupRepository
    {
        private MoneyLeakFreeDbContext context;

        public ExpenseGroupRepository(MoneyLeakFreeDbContext context)
        {
            this.context = context;
        }

        public ExpenseGroup Add(ExpenseGroup newExpenseGroup)
        {
            return this.context.ExpenseGroups.Add(newExpenseGroup);
        }

        public IEnumerable<ExpenseGroup> Get(Expression<Func<ExpenseGroup, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpenseGroup> GetAll()
        {
            return this.context.ExpenseGroups;
        }

        public ExpenseGroup GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ExpenseGroup expenseGroup)
        {
            throw new NotImplementedException();
        }
    }
}
