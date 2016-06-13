using CQRS.Demo.CommandStack.Domain.Model;

namespace CQRS.Demo.Infrastructure.Persistence.SqlServer.Repositories.Adapters
{
    public class Adapter 
    {
        public static images RequestToTweet(TweetRequest entity)
        {
            var tweet = new images()
            {
                TweetId = entity.TweetId,
                text = entity.Text,
                media_url = entity.MediaUrl
            };
            return tweet;
        }
    }
}