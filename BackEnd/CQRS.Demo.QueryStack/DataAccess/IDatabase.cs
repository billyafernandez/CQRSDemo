using System.Linq;
using CQRS.Demo.Infrastructure.Persistence.SqlServer;

namespace CQRS.Demo.QueryStack.DataAccess
{
    public interface IDatabase
    {
        IQueryable<images> Images { get; }
    }
}