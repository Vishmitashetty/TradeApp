using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TradeData;


namespace WebApiPrac.Controllers
{
    public class PositionController : ApiController
    {
        TradeContext context = new TradeContext();
        public IEnumerable<Classes.Position> GetPosition() { 

              
      return context.Positions.SqlQuery("[dbo].TickTrade4");
}
        


    }
}
