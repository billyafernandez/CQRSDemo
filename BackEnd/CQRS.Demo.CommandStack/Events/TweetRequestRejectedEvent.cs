using System;
using CQRS.Demo.Infrastructure.Framework;

namespace CQRS.Demo.CommandStack.Events
{
    public class TweetRequestRejectedEvent : Event
    {
        public TweetRequestRejectedEvent(Guid requestId, string reason = "")
        {
            RequestId = requestId;
            Reason = reason;
        }

        public Guid RequestId { get; private set; }
        public string Reason { get; private set; }
    }
}