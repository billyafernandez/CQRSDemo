using CQRS.Demo.CommandStack.Handlers;
using CQRS.Demo.CommandStack.Sagas;
using CQRS.Demo.Infrastructure.Framework;
using CQRS.Demo.Infrastructure.Framework.EventStore;

namespace CQRS.Demo.Web.API
{
    public class BusConfig
    {
        public static void Initialize()
        {
            WebApiApplication.Bus = new InMemoryBus(new SqlEventStore());

            WebApiApplication.Bus.RegisterSaga<TweetSaga>();
            //WebApiApplication.Bus.RegisterSaga<BookingSaga>();
            //WebApiApplication.Bus.RegisterHandler<BookingRejectedHandler>();
            //WebApiApplication.Bus.RegisterHandler<EmailHandler>();
        }
    }
}