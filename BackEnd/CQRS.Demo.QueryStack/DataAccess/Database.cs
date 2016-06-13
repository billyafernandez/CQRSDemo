using System.Linq;
using CQRS.Demo.Infrastructure.Persistence.SqlServer;

namespace CQRS.Demo.QueryStack.DataAccess
{
    public class Database : IDatabase
    {
        private readonly CQRS_DemoEntities _cqrs;
        public Database()
        {
            //_merlo = new expoware_MerloEntities();
            _cqrs = new CQRS_DemoEntities();
        }

        public IQueryable<images> Images
        {
            get
            {
                return _cqrs.images;
            }
        }
    }
}