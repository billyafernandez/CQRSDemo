using System;
using CQRS.Demo.CommandStack.Domain.Common;
using CQRS.Demo.CommandStack.Domain.Model.Events;

namespace CQRS.Demo.CommandStack.Domain.Model
{
    public class TweetRequest : Aggregate
    {
        protected TweetRequest()
        {
            // Assign a unique temporary reference
            Id = Guid.NewGuid();
        }

        public string TweetId { get; private set; }
        public string Text { get; private set; }
        public string MediaUrl { get; private set; }
        public Boolean BeenProcessed { get; private set; }

        public void Apply(TweetRequestCreatedEvent evt)
        {
            TweetId = evt.TweetId;
            Text = evt.Text;
            MediaUrl = evt.MediaUrl;
        }


        public static class Factory
        {
            public static TweetRequest Create(string tweetId, string text, string mediaUrl)
            {
                var requested = new TweetRequestCreatedEvent(tweetId, text, mediaUrl);
                var request = new TweetRequest();
                request.RaiseEvent(requested);
                return request;
            }
        }
    }
}