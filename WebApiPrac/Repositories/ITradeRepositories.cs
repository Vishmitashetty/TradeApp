using TradeData;
using WebApiPrac.Repositories;

namespace WebApiPrac.Repositories
{
    public interface ITradeRepositories
    {
        Classes.Trade Add(Classes.Trade item);
        Classes.Trade Get(int id);
        System.Collections.Generic.IEnumerable<Classes.Trade> GetAll();
    }
}