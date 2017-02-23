using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.InfrastructureContext
{
    public class MoneyLeakFreeDbContext : DbContext
    {
        public MoneyLeakFreeDbContext() : base("name=MoneyLeakFreeConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<MoneyMovement> MoneyMovements { get; set; }

        public DbSet<ExpenseGroup> ExpenseGroups { get; set; }

        public DbSet<ReportConfiguration> ReportConfigurations { get; set; }
    }
}
