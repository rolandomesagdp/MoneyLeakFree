using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Domain.Entities
{
    public class MoneyMovement
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string Concept { get; set; }

        public DateTime MovementDate { get; set; }

        public MovementType Income { get; set; }

        public Guid MovementGroupId { get; set; }

        public virtual ExpenseGroup MovementGroup { get; set; }

        public virtual User User { get; set; }
    }
}
