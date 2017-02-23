using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MoneyMovement
    {
        public Guid Id { get; set; }

        public string Concept { get; set; }

        public DateTime MovementDate { get; set; }

        public MovementType Income { get; set; }

        public Guid MovementGroupId { get; set; }

        public virtual ExpenseGroup MovementGroup { get; set; }
    }
}
