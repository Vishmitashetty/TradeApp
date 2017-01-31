using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradeData;
using WebApiPrac.Repositories;

namespace WebApiPrac.Repositories
{
    public class TradeRepositories: ITradeRepositories
    {
        TradeContext ProductDB = new TradeContext();

        public IEnumerable<Classes.Trade> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            return ProductDB.Trades;
        }

        public Classes.Trade Get(int id)
        {
            // TO DO : Code to find a record in database
            return ProductDB.Trades.Find(id);
        }

        public Classes.Trade Add(Classes.Trade item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to save record into database
            ProductDB.Trades.Add(item);
            ProductDB.SaveChanges();
            return item;
        }
    }
}