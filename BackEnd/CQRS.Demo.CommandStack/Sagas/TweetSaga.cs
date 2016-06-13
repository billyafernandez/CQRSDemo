using CQRS.Demo.CommandStack.Commands;
using CQRS.Demo.CommandStack.Domain.Model;
using CQRS.Demo.CommandStack.Events;
using CQRS.Demo.Infrastructure.Framework;
using CQRS.Demo.Infrastructure.Framework.EventStore;
using CQRS.Demo.Infrastructure.Framework.Repositories;
using CQRS.Demo.Infrastructure.Persistence.SqlServer.Repositories;

namespace CQRS.Demo.CommandStack.Sagas
{
    public class TweetSaga : Saga,
        IStartWithMessage<RequestTweetCommand>
    {
        private readonly IRepository _repository;

        public TweetSaga(IBus bus, IEventStore eventStore)
            : base(bus, eventStore)
        {
            _repository = new TweetRepository();
        }

        public TweetSaga(IBus bus, IEventStore eventStore, IRepository repository)
            : base(bus, eventStore)
        {
            _repository = repository;
        }

        public void Handle(RequestTweetCommand message)
        {
            var request = TweetRequest.Factory.Create(message.TweetId, message.Text, message.MediaUrl);
            var response = _repository.CreateTweetFromRequest(request);
            if (!response.Success)
            {
                var rejected = new TweetRequestRejectedEvent(request.Id, response.Description);
                Bus.RaiseEvent(rejected);
                return;
            }

            //var slotInfo = request.ToSlotInfo();
            var created = new TweetCreatedEvent(); //request.Id, response.AggregateId, slotInfo);
            Bus.RaiseEvent(created);
        }
    }
}