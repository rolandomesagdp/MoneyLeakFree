using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Domain.Entities
{
    public class ReportConfiguration
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ReportType ReportType { get; set; }

        public virtual User User { get; set; }
    }
}
