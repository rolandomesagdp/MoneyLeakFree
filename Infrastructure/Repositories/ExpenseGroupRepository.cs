﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using MoneyLeakFree.Infrastructure.Contracts;
using MoneyLeakFree.Infrastructure.InfrastructureContext;
using MoneyLeakFree.Domain.Entities;

namespace MoneyLeakFree.Infrastructure.Repositories
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

        public IEnumerable<ExpenseGroup> GetAllForUser(Guid userId)
        {
            return this.context.ExpenseGroups.Where(x => x.UserId == userId.ToString());
        }

        public ExpenseGroup GetById(Guid id)
        {
            return this.context.ExpenseGroups.Where(x => x.Id == id.ToString()).FirstOrDefault();
        }

        public void Remove(ExpenseGroup expenseGroup)
        {
            this.context.ExpenseGroups.Remove(expenseGroup);
        }
    }
}
