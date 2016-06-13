using System;
using System.Collections.Generic;
using System.Linq;
using CQRS.Demo.Infrastructure.EventStore.SqlServer.Data;

namespace CQRS.Demo.Infrastructure.EventStore.SqlServer.Repositories
{
    public class EventRepository
    {
        private readonly MerloEventStore _db = new MerloEventStore();

        public void Store(LoggedEvents eventToLog)
        {
            eventToLog.TimeStamp = DateTime.Now;
            _db.LoggedEvents.Add(eventToLog);
            _db.SaveChanges();
        }

        public IList<LoggedEvents> All(int aggregateId)
        {
            var events = (from e in _db.LoggedEvents where e.AggregateId == aggregateId select e).ToList();
            return events;
        }
    }
}