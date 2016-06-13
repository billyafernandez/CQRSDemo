using CQRS.Demo.CommandStack.Events;
using CQRS.Demo.Infrastructure.Framework;
using CQRS.Demo.Infrastructure.Framework.EventStore;

namespace CQRS.Demo.CommandStack.Handlers
{
    public class TweetRejectedHandler : Handler,
        IHandleMessage<TweetRequestRejectedEvent>
    {
        public TweetRejectedHandler(IEventStore eventStore)
            : base(eventStore)
        {
        }

        public void Handle(TweetRequestRejectedEvent message)
        {
            throw new System.NotImplementedException();
        }
    }
}