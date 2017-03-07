using Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Infrastructure.Contracts;
using Common.OperationResult;

namespace Business.Services
{
    public class ExpenseGroupService : IExpenseGroupService
    {
        private readonly IUnitOfWork unitOfwork;
        private OperationResultBuilder<ExpenseGroup> serviceResultBuilder;

        public ExpenseGroupService(IUnitOfWork unitOfwork)
        {
            this.unitOfwork = unitOfwork;
            this.serviceResultBuilder = new OperationResultBuilder<ExpenseGroup>();
        }

        public OperationResult<ExpenseGroup> Add(ExpenseGroup expenseGroup)
        {
            var serviceResult = new OperationResult<ExpenseGroup>();
            try
            {
                expenseGroup.Id = Guid.NewGuid().ToString();
                expenseGroup.CreationDate = DateTime.Now;
                expenseGroup.LastUpdateDate = DateTime.Now;

                var createdExpenseGroup = this.unitOfwork.ExpenseGroupRepository.Add(expenseGroup);
                this.unitOfwork.SaveChanges();
                
                serviceResult = this.serviceResultBuilder.BuildOperationResult(createdExpenseGroup, OperationResultType.Success, string.Empty);
            }
            catch
            {
                var message = $"There was an error while trying to add Expense Group {expenseGroup.Name}";
                serviceResult = this.serviceResultBuilder.BuildOperationResult(expenseGroup, OperationResultType.Error, message);
            }

            return serviceResult;
        }

        public void Delete(ExpenseGroup expenseGroup)
        {
            throw new NotImplementedException();
        }

        public OperationResult<ExpenseGroup> Edit(ExpenseGroup expenseGroup)
        {
            var operationResult = new OperationResult<ExpenseGroup>();

            try
            {
                var expenseGroupToEdit = this.unitOfwork.ExpenseGroupRepository.GetById(Guid.Parse(expenseGroup.Id));

                expenseGroupToEdit.Name = expenseGroup.Name;
                expenseGroupToEdit.Active = expenseGroup.Active;
                expenseGroupToEdit.LastUpdateDate = DateTime.Now;

                this.unitOfwork.SaveChanges();

                operationResult = serviceResultBuilder.BuildOperationResult(expenseGroupToEdit, OperationResultType.Success, string.Empty);
            }
            catch
            {
                var message = $"There was an error while trying to update Expense Group with Id {expenseGroup.Id}";
                operationResult = serviceResultBuilder.BuildOperationResult(expenseGroup, OperationResultType.Error, message);
            }

            return operationResult;
        }

        public OperationResult<ExpenseGroup> Delete(Guid id)
        {
            var operationResult = new OperationResult<ExpenseGroup>();

            try
            {
                var expenseGroupToDelete = this.unitOfwork.ExpenseGroupRepository.GetById(id);

                this.unitOfwork.ExpenseGroupRepository.Remove(expenseGroupToDelete);
                this.unitOfwork.SaveChanges();

                var message = $"Expense Group with Id {id.ToString()} was correctly deleted.";
                operationResult = serviceResultBuilder.BuildOperationResult(null, OperationResultType.Success, string.Empty);
            }
            catch
            {
                var message = $"There was an error while trying to update Expense Group with Id {id}";
                operationResult = serviceResultBuilder.BuildOperationResult(null, OperationResultType.Error, message);
            }

            return operationResult;
        }

        public IEnumerable<ExpenseGroup> GetAll()
        {
            return this.unitOfwork.ExpenseGroupRepository.GetAll();
        }

        public OperationResult<ExpenseGroup> GetById(Guid id)
        {
            var operationResult = new OperationResult<ExpenseGroup>();
            try
            {
                var expenseGroup = this.unitOfwork.ExpenseGroupRepository.GetById(id);

                var message = "Expense Group correctly found";
                operationResult = this.serviceResultBuilder.BuildOperationResult(expenseGroup, OperationResultType.Success, message);
            }
            catch
            {
                var message = $"There was an error trying to find Expense Group with id {id.ToString()}";
                operationResult = this.serviceResultBuilder.BuildOperationResult(null, OperationResultType.Error, message);
            }

            return operationResult;
        }
    }
}
