using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeData
{
   public class TradeContext:DbContext
    {
        public DbSet<Classes.Security> Securities { get; set; }
        public DbSet<Classes.Trade> Trades { get; set; }
        public DbSet<Classes.Position> Positions { get; set; }
    }
}
