using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ExpenseGroup
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
    }
}
