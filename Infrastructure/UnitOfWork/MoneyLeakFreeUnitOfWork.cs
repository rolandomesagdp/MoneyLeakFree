﻿using MoneyLeakFree.Infrastructure.Contracts;
using MoneyLeakFree.Infrastructure.InfrastructureContext;
using MoneyLeakFree.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Infrastructure.UnitOfWork
{
    public class MoneyLeakFreeUnitOfWork : IUnitOfWork
    {
        private MoneyLeakFreeDbContext dbContext;
        private IExpenseGroupRepository expenseGroupRepository;

        public MoneyLeakFreeUnitOfWork(MoneyLeakFreeDbContext context)
        {
            this.dbContext = context;
        }
        public IExpenseGroupRepository ExpenseGroupRepository
        {
            get
            {
                if (this.expenseGroupRepository == null)
                {
                    this.expenseGroupRepository = new ExpenseGroupRepository(this.dbContext); 
                }

                return this.expenseGroupRepository;
            }
        }

        public void SaveChanges()
        {
            this.dbContext.SaveChanges();
        }
    }
}
