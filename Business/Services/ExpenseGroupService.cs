using Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infrastructure.Contracts;

namespace Business.Services
{
    public class ExpenseGroupService : IExpenseGroupService
    {
        private readonly IUnitOfWork unitOfwork;

        public ExpenseGroupService(IUnitOfWork unitOfwork)
        {
            this.unitOfwork = unitOfwork;
        }

        public ExpenseGroup Add(ExpenseGroup expenseGroup)
        {
            throw new NotImplementedException();
        }

        public void Delete(ExpenseGroup expenseGroup)
        {
            throw new NotImplementedException();
        }

        public ExpenseGroup Edit(ExpenseGroup expenseGroup)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExpenseGroup> GetAll()
        {
            var expenseGroup = new ExpenseGroup()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Pocket Money",
                Active = true,
                CreationDate = DateTime.Now,
                LastUpdateDate = DateTime.Now
            };

            this.unitOfwork.ExpenseGroupRepository.Add(expenseGroup);
            this.unitOfwork.SaveChanges();

            return this.unitOfwork.ExpenseGroupRepository.GetAll();
        }

        public ExpenseGroup GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
