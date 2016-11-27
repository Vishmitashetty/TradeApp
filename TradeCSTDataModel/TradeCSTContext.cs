using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TradeCST;
namespace TradeCSTDataModel
{
    public class TradeCSTContext:DbContext
    {
        public DbSet<CounterParty> CounterParties { get; set; }
        public DbSet<Security> Securities { get; set; }
        public DbSet<Trade> Trades { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trade>().Property(x => x.Price).HasPrecision(15, 6);
            modelBuilder.Entity<Trade>().Property(x => x.NetAmount).HasPrecision(15, 6);
        }
    }
}
