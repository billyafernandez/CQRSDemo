using System.Collections.Generic;
using System.Web.Script.Serialization;
using CQRS.Demo.Infrastructure.EventStore.SqlServer.Data;
using CQRS.Demo.Infrastructure.EventStore.SqlServer.Repositories;

namespace CQRS.Demo.Infrastructure.Framework.EventStore
{
    public class SqlEventStore : IEventStore
    {
        private static readonly EventRepository EventRepository = new EventRepository();

        public IEnumerable<Event> All(string matchId)
        {
            return null; //EventRepository.All(matchId);
        }

        public void Save<T>(T theEvent) where T : Event
        {
            var loggedEvent = new LoggedEvents()
            {
                Action = theEvent.Name,
                AggregateId = theEvent.SagaId,
                Cargo = new JavaScriptSerializer().Serialize(theEvent)
            };

            EventRepository.Store(loggedEvent);
        }
    }
}