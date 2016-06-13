using CQRS.Demo.Infrastructure.Framework;

namespace CQRS.Demo.CommandStack.Events
{
    public class TweetRequestedEvent : Event
    {
        public TweetRequestedEvent(string text, string mediaUrl)
        {
            Text = text;
            MediaUrl = mediaUrl;
        }

        public string Text { get; private set; }
        public string MediaUrl { get; private set; }
    }
}