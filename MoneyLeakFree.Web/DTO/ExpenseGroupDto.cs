using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyLeakFree.Web.DTO
{
    public class ExpenseGroupDto
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}