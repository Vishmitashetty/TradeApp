using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiPrac.Repositories;
using TradeData;

namespace WebApiPrac.Controllers
{
    public class TradeController : ApiController
    {
        static readonly ITradeRepositories repository = new TradeRepositories();

        public IEnumerable<Classes.Trade> GetAllProducts()
        {
            return repository.GetAll();
        }

        public Classes.Trade PostProduct(Classes.Trade item)
        {
            return repository.Add(item);
        }
    }
}
