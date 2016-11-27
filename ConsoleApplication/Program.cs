using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeCST;
using TradeCSTDataModel;
using System.Data.Entity;
using TradeCSTDataModel.Migrations;
using System.Linq.Expressions;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TradeCSTContext, Configuration>());
            //GetCounterParty();
            //GetSecurity();
            //GetTrade();
            GetSecName();
            //GetAllTrade();
            // Deletetrade();
            //UpdateQty();
            //spcrun();


        }
        private static void GetCounterParty()
        {
            var counter1 = new CounterParty
            {
                CounterPartyId = 1,
                CounterPartyName = "MSCO"

            };
            var counter2 = new CounterParty
            {
                CounterPartyId = 2,
                CounterPartyName = "GSCO"

            };
            var counter3 = new CounterParty
            {
                CounterPartyId = 3,
                CounterPartyName = "JPM"

            };

            using (var context = new TradeCSTContext())
            {
                context.Database.Log = Console.WriteLine;
                context.CounterParties.AddRange(new List<CounterParty> {counter1, counter2, counter3 });
               // context.CounterParties.Add(counter1);
                context.SaveChanges();

            }
            Console.ReadKey();
        }
        private static void GetSecurity()
        {
            var security1 = new Security
            {
                SecurityId = 1,
                CUSIP = "03852U106",
                SEDOL = "BH3XG17",
                ISIN = "US03852U1060",
                SecName = "BANK OF AMERICA"
            };
            var security2 = new Security
            {
                SecurityId = 2,
                CUSIP = "17275R102",
                SEDOL = "2198163",
                ISIN = "US17275R1023",
                SecName = "CISCO SYSTEM INC"
            };
            var security3 = new Security
            {
                SecurityId = 3,
                CUSIP = "19122T109",
                SEDOL = "B42BPG9",
                ISIN = "GB00BDCPN049",
                SecName = "COCA-COLA ENTERTAINMENT"
            };
            var security4 = new Security
            {
                SecurityId = 4,
                CUSIP = "931142103",
                SEDOL = "293621",
                ISIN = "US9311421039",
                SecName = "WALT-MART INC"
            };
            var security5 = new Security
            {
                SecurityId = 5,
                CUSIP = "855244109",
                SEDOL = "2842255",
                ISIN = "US8552441094",
                SecName = "STAR BUCKS CORP"
            };
            var security6 = new Security
            {
                SecurityId = 6,
                CUSIP = "594918104",
                SEDOL = "2588173",
                ISIN = "US5949181045",
                SecName = "MICROSOFT CORP"
            };
            using (var context = new TradeCSTContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Securities.AddRange(new List<Security> { security1, security2, security3, security4, security5, security6 });

                context.SaveChanges();

            }
            Console.ReadKey();
        }
        private static void GetTrade()
        {
            //var trade1 = new Trade
            //{
            //    TradeId = 1,
            //    CounterPartyId = 1,
            //    SecurityId = 1,
            //    TransactionType = "B",
            //    Qty = 135,
            //    Price = 10.5M,
            //    NetAmount = 1383,
            //    TradeDate = new DateTime(2016, 8, 18)
            //};
            //var trade2 = new Trade
            //{
            //    TradeId = 2,
            //    CounterPartyId = 2,
            //    SecurityId = 2,
            //    TransactionType = "B",
            //    Qty = 211,
            //    Price = 100,
            //    NetAmount = 21258,
            //    TradeDate = new DateTime(2016, 8, 18)
            //};
            //var trade3 = new Trade
            //{
            //    TradeId = 3,
            //    CounterPartyId = 3,
            //    SecurityId = 3,
            //    TransactionType = "S",
            //    Qty = -500,
            //    Price = 10,
            //    NetAmount = -5000,
            //    TradeDate = new DateTime(2016, 8, 18)
            //};
            //var trade4 = new Trade
            //{
            //    TradeId = 4,
            //    CounterPartyId = 3,
            //    SecurityId = 4,
            //    TransactionType = "B",
            //    Qty = 10000,
            //    Price = 20,
            //    NetAmount = 200000,
            //    TradeDate = new DateTime(2016, 8, 18)
            //};
            //var trade5 = new Trade
            //{
            //    TradeId = 5,
            //    CounterPartyId = 2,
            //    SecurityId = 3,
            //    TransactionType = "S",
            //    Qty = -20000,
            //    Price = 5,
            //    NetAmount = -110000,
            //    TradeDate = new DateTime(2016, 8, 18)
            //};
            //using (var context = new TradeCSTContext())
            //{
            //    context.Database.Log = Console.WriteLine;
            //    context.Trades.AddRange(new List<Trade> { trade3, trade4, trade5 });
            //    context.Trades.Add(trade2);
            //    context.SaveChanges();

            //}
        }

        private static void GetSecName()
        {
            using(var context = new TradeCSTContext())
            {
                var innerJoinQuery = from Sec in context.Securities
                                     join trade in context.CounterParties  on Sec.SecurityId equals trade.CounterPartyId select new { Sec.SecName };

                 
                // var secN = context.Securities.Include(n => n.SecurityId).FirstOrDefault(SELECT CounterPartyId from CounterParty WHERE CounterPartyId = 1 );
                //    .Where(n => n.CounterPartyId == 1).FirstOrDefault();

                //int keyval = (int)secId;
                // var secName = context.Securities.Find(secId.SecurityId);

                foreach (var query in innerJoinQuery)
                {
                    Console.WriteLine(query);
                }


            }
            Console.ReadKey();
        }
        private static void GetAllTrade()
        {
            //using (var context = new TradeCSTContext())
            //{
            //    var trades = context.Trades
            //        .Where(n => n.SecurityId == 3);
            //    foreach (var trade in (trades.Select(TradeId)))
            //    {
            //        //  Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", trade.TradeId, trade.CounterPartyId, trade.SecurityId, trade.TransactionType, trade.Qty, trade.Price, trade.NetAmount, trade.TradeDate, trade.Maturity);
            //        Console.WriteLine(trade);
            //    }

           // }
            Console.ReadKey();
        }
        private static void UpdateQty()
        {
            using (var context = new TradeCSTContext())
            {


                Expression<Func<Trade, bool>> sid = c => c.SecurityId == 3;

                Expression<Func<Trade, bool>> cid = x => x.CounterPartyId == 3;
                // var qty = context.Trades
                //.Where(sid).Where(cid).FirstOrDefault();
                // Console.WriteLine(qty.Qty);
                //qty.Qty = 255;
                //new try
                var qty = context.Trades
                    .Where(n=>n.SecurityId == 3&&n.CounterPartyId == 3).FirstOrDefault();
                Console.WriteLine(qty.Qty);
                context.SaveChanges();
            }
            Console.ReadKey();
        }
        private static void Deletetrade()
        {
            using (var context = new TradeCSTContext()) {
                var del = context.Trades
                    .Where(n=>n.CounterPartyId == 1).FirstOrDefault();
                context.Trades.Remove(del);
                context.SaveChanges();

            }
        }
        private static void spcrun() {
            int Sum = 0;
            using (var context = new TradeCSTContext()) {
                context.Database.Log = Console.WriteLine;
               
                    var blogId = "GSCO";

                    var blogs = context.Trades.SqlQuery("[dbo].[Trade3] @p0", blogId);

                foreach (var blog in blogs)
                {
                    Sum = Sum + blog.Qty;

                }
                Console.WriteLine(Sum);
            }
            Console.ReadKey();
        }
        
    }
}
