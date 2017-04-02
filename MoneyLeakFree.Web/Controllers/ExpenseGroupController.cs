using MoneyLeakFree.Common.OperationResult;
using MoneyLeakFree.Web.Contracts;
using MoneyLeakFree.Web.DTO;
using System;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace MoneyLeakFree.Web.Controllers
{
    [Authorize]
    public class ExpenseGroupController : ApiController
    {
        private readonly IExpenseGroupWorker expenseGroupWorker;

        public ExpenseGroupController(IExpenseGroupWorker expenseGroupWorker)
        {
            this.expenseGroupWorker = expenseGroupWorker;
        }

        // GET api/values
        [Route("api/expensegroups")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
            var expenseGroups = this.expenseGroupWorker.GetAllForUser(Guid.Parse(userId));

            return Ok(expenseGroups);
        }

        // GET api/values/5
        [Route("api/expensegroup/{id}")]
        [HttpGet]
        public IHttpActionResult Get(Guid id)
        {
            IHttpActionResult actionResult;

            var workerResult = this.expenseGroupWorker.GetById(id);

            if (workerResult.OperationResultType == OperationResultType.Success)
            {
                actionResult = Ok(workerResult.Entity);
            }
            else
            {
                actionResult = BadRequest(workerResult.Message);
            }

            return actionResult;
        }

        // POST api/values
        [Route("api/expensegroup/create")]
        public IHttpActionResult Post([FromBody]ExpenseGroupDto expenseGroup)
        {
            IHttpActionResult actionResult;

            var userId = System.Web.HttpContext.Current.User.Identity.GetUserId();
            expenseGroup.UserId = Guid.Parse(userId);

            var workerResult = this.expenseGroupWorker.Create(expenseGroup);

            if (workerResult.OperationResultType == OperationResultType.Success)
            {
                actionResult = Ok(workerResult.Entity);
            }
            else
            {
                actionResult = BadRequest(workerResult.Message);
            }

            return actionResult;
        }

        // PUT api/values/5
        [Route("api/expensegroup/edit")]
        public IHttpActionResult Put([FromBody]ExpenseGroupDto expenseGroup)
        {
            IHttpActionResult actionResult;

            var workerResult = this.expenseGroupWorker.Edit(expenseGroup);

            if (workerResult.OperationResultType == OperationResultType.Success)
            {
                actionResult = Ok(workerResult.Entity);
            }
            else
            {
                actionResult = BadRequest(workerResult.Message);
            }

            return actionResult;
        }

        // DELETE api/values/5
        [Route("api/expensegroup/delete/{id}")]
        public IHttpActionResult Delete(Guid id)
        {
            IHttpActionResult actionResult;

            var workerResult = this.expenseGroupWorker.Delete(id);

            if (workerResult.OperationResultType == OperationResultType.Success)
            {
                actionResult = Ok(workerResult.Message);
            }
            else
            {
                actionResult = BadRequest(workerResult.Message);
            }

            return actionResult;
        }
    }
}
