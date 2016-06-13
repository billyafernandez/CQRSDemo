using System.Linq;
using CQRS.Demo.Infrastructure.Persistence.SqlServer;

namespace CQRS.Demo.QueryStack.DataAccess.Extensions 
{
    public static class TweetExtensions
    {
        public static IQueryable<images> ForCourts(this IQueryable<images> bookings, params int[] courtIds)
        {
            return null; //bookings.Where(b => courtIds.Contains(b.CourtId));
        }
    }
}