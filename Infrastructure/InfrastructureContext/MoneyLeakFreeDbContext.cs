using Microsoft.AspNet.Identity.EntityFramework;
using MoneyLeakFree.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLeakFree.Infrastructure.InfrastructureContext
{
    public class MoneyLeakFreeDbContext : IdentityDbContext<User>
    {
        public MoneyLeakFreeDbContext() : base("name=MoneyLeakFreeConnectionString")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<MoneyMovement> MoneyMovements { get; set; }

        public DbSet<ExpenseGroup> ExpenseGroups { get; set; }

        public DbSet<ReportConfiguration> ReportConfigurations { get; set; }


        public static MoneyLeakFreeDbContext Create()
        {
            return new MoneyLeakFreeDbContext();
        }
    }
}
