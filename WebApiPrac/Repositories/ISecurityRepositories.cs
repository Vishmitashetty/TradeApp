using System.Linq;
using TradeData;

namespace WebApiPrac.Repositories
{
    public interface ISecurityRepositories
    {
        Classes.Security Add(Classes.Security item);
        Classes.Security Get(int id);
        IQueryable<Classes.Security> GetAll();
    }
}