using CQRS.Demo.Infrastructure.Framework;

namespace CQRS.Demo.CommandStack.Commands
{
    public class RequestTweetCommand : Command
    {
        public RequestTweetCommand(string tweetId, string text, string mediaUrl)
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