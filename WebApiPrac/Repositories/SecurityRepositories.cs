using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradeData;

namespace WebApiPrac.Repositories
{
    public class SecurityRepositories: ISecurityRepositories
    {
        TradeContext ProductDB = new TradeContext();

        public IQueryable<Classes.Security> GetAll()
        {
            // TO DO : Code to get the list of all the records in database
            return ProductDB.Securities.AsQueryable();
        }

        public Classes.Security Get(int id)
        {
            // TO DO : Code to find a record in database
            return ProductDB.Securities.Find(id);
        }

        public Classes.Security Add(Classes.Security item)
        {
            try {
                if (item == null)
                {
                    throw new ArgumentNullException("item");
                }
                Console.WriteLine(item);
                // TO DO : Code to save record into database
                ProductDB.Securities.Add(item);
                ProductDB.SaveChanges();
            }
            catch (Exception ex) {

                Console.WriteLine("Exception caught: {0}", ex);
            }
            return item;
        }
    }
}