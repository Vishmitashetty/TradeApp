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
    public class SecurityController : ApiController
    {
        static readonly ISecurityRepositories repository = new SecurityRepositories();

        public IQueryable<Classes.Security> GetAllProducts()
        {
            return repository.GetAll().AsQueryable();
        }

        public Classes.Security PostProduct(Classes.Security item)
        {
         
            return repository.Add(item);
        }
    }
}
