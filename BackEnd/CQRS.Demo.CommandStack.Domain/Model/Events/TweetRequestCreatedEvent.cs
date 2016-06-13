using CQRS.Demo.CommandStack.Domain.Common;

namespace CQRS.Demo.CommandStack.Domain.Model.Events
{
    public class TweetRequestCreatedEvent : DomainEvent
    {
        public TweetRequestCreatedEvent(string tweetId, string text, string mediaUrl)
        {
            TweetId = tweetId;
            Text = text;
            MediaUrl = mediaUrl;
        }

        public string TweetId { get; private set; }
        public string Text { get; private set; }
        public string MediaUrl { get; private set; }
    }
}