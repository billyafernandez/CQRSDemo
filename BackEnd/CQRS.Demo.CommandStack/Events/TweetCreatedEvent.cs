using System;
using CQRS.Demo.Infrastructure.Framework;
using CQRS.Demo.SharedKernel;

namespace CQRS.Demo.CommandStack.Events
{
    public class TweetCreatedEvent : Event
    {
        public TweetCreatedEvent()
        {
        }

        public TweetCreatedEvent(int id)
        {
            Id = id;
            SagaId = id;
        }

        public int Id { get; set; }
    }
}