using CQRS.Demo.CommandStack.Domain.Model;
using CQRS.Demo.Infrastructure.Persistence.SqlServer;

namespace CQRS.Demo.CommandStack.Domain.Services.Adapter
{
    public class TweetAdapter
    {
        public static images ToDataModel(TweetRequest entity)
        {
            var image = new images
            {
                TweetId = entity.TweetId,
                text = entity.Text,
                media_url = entity.MediaUrl
            };
            return image;
        }
    }
}