using MoneyLeakFree.Web.Contracts;
using MoneyLeakFree.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoneyLeakFree.Web.Controllers
{
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
            var expenseGroups = this.expenseGroupWorker.GetAll();

            return Ok(expenseGroups);
        }

        // GET api/values/5
        [Route("api/person/{id}")]
        [HttpGet]
        public IHttpActionResult Get(Guid id)
        {
            var person = new UserModel()
            {
                Id = id,
                Name = "Rolando",
                LastName = "Mesa"
            };

            return Ok(person);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
