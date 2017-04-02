using MoneyLeakFree.Web.Contracts;
using System;
using System.Collections.Generic;
using MoneyLeakFree.Web.DTO;
using MoneyLeakFree.Business.Contracts;
using MoneyLeakFree.Common.OperationResult;
using MoneyLeakFree.Domain.Entities;

namespace MoneyLeakFree.Web.Workers
{
    public class ExpenseGroupWorker : IExpenseGroupWorker
    {
        private readonly IExpenseGroupService expenseGroupService;
        private OperationResultBuilder<ExpenseGroupDto> workerResultBuilder;

        public ExpenseGroupWorker(IExpenseGroupService expenseGroupService)
        {
            this.expenseGroupService = expenseGroupService;
            this.workerResultBuilder = new OperationResultBuilder<ExpenseGroupDto>();
        }

        public IEnumerable<ExpenseGroupDto> GetAllForUser(Guid userId)
        {
            var expenceGroupDtosToReturn = new List<ExpenseGroupDto>();

            var expenseGroups = this.expenseGroupService.GetAllForuser(userId);

            foreach (var expenseGroup in expenseGroups)
            {
                var expenseGroupDto = this.GetExpenseGroupDtoFromExpenseGroup(expenseGroup);

                expenceGroupDtosToReturn.Add(expenseGroupDto);
            }

            return expenceGroupDtosToReturn;
        }

        public OperationResult<ExpenseGroupDto> GetById(Guid id)
        {
            var workerResult = new OperationResult<ExpenseGroupDto>();

            var serviceResult = this.expenseGroupService.GetById(id);
            var expenseGroupDtoToReturn = new ExpenseGroupDto()
            {
                Id = Guid.Parse(serviceResult.Entity.Id),
                Name = serviceResult.Entity.Name,
                Active = serviceResult.Entity.Active,
                CreationDate = serviceResult.Entity.CreationDate,
                LastUpdateDate = serviceResult.Entity.LastUpdateDate
            };

            workerResult = this.workerResultBuilder.BuildOperationResult(expenseGroupDtoToReturn, 
                                                                        serviceResult.OperationResultType, 
                                                                        serviceResult.Message);

            return workerResult;
        }

        public OperationResult<ExpenseGroupDto> Edit(ExpenseGroupDto expenseGroupToEdit)
        {
            var workerResult = new OperationResult<ExpenseGroupDto>();

            var expenseGroup = this.GetExpenseGroupFromExpenseGroupDto(expenseGroupToEdit);
            var serviceResult = this.expenseGroupService.Edit(expenseGroup);

            var editedExpenseGroup = this.GetExpenseGroupDtoFromExpenseGroup(serviceResult.Entity);

            workerResult = this.workerResultBuilder.BuildOperationResult(editedExpenseGroup, serviceResult.OperationResultType, serviceResult.Message);

            return workerResult;
        }

        public OperationResult<ExpenseGroupDto> Create(ExpenseGroupDto expenseGroupDto)
        {
            var workerResult = new OperationResult<ExpenseGroupDto>();

            var expenseGroup = this.GetExpenseGroupFromExpenseGroupDto(expenseGroupDto);
            var serviceResult = this.expenseGroupService.Add(expenseGroup);

            var createdExpenseGroup = this.GetExpenseGroupDtoFromExpenseGroup(serviceResult.Entity);

            workerResult = this.workerResultBuilder.BuildOperationResult(createdExpenseGroup, serviceResult.OperationResultType, serviceResult.Message);

            return workerResult;
        }

        public OperationResult<ExpenseGroupDto> Delete(Guid id)
        {
            var workerResult = new OperationResult<ExpenseGroupDto>();

            var serviceResult = this.expenseGroupService.Delete(id);

            workerResult = this.workerResultBuilder.BuildOperationResult(new ExpenseGroupDto(), serviceResult.OperationResultType, serviceResult.Message);

            return workerResult;
        }

        #region Private Methods

        private ExpenseGroup GetExpenseGroupFromExpenseGroupDto(ExpenseGroupDto expenseGroupDto)
        {
            var expenseGroup = new ExpenseGroup()
            {
                Id = expenseGroupDto.Id.ToString(),
                UserId = expenseGroupDto.UserId.ToString(),
                Name = expenseGroupDto.Name,
                Active = expenseGroupDto.Active,
                CreationDate = expenseGroupDto.CreationDate,
                LastUpdateDate = expenseGroupDto.LastUpdateDate
            };

            return expenseGroup;
        }

        private ExpenseGroupDto GetExpenseGroupDtoFromExpenseGroup(ExpenseGroup expenseGroup)
        {
            var expenseGroupDto = new ExpenseGroupDto()
            {
                Id = Guid.Parse(expenseGroup.Id),
                Name = expenseGroup.Name,
                Active = expenseGroup.Active,
                CreationDate = expenseGroup.CreationDate,
                LastUpdateDate = expenseGroup.LastUpdateDate
            };

            return expenseGroupDto;
        }

        #endregion
    }
}