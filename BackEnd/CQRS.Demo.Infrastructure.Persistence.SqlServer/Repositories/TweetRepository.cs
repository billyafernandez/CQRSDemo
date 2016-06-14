using System;
using System.Linq;
using CQRS.Demo.CommandStack.Domain.Common;
using CQRS.Demo.CommandStack.Domain.Model;
using CQRS.Demo.Infrastructure.Framework;
using CQRS.Demo.Infrastructure.Framework.Repositories;
using CQRS.Demo.Infrastructure.Persistence.SqlServer.Repositories.Adapters;

namespace CQRS.Demo.Infrastructure.Persistence.SqlServer.Repositories
{
    public class TweetRepository : IRepository
    {
        private readonly CQRS_DemoEntities _cqrsDemoEntities;
        public TweetRepository()
        {
            _cqrsDemoEntities = new CQRS_DemoEntities();
        }

        public T GetById<T>(int id) where T : IAggregate
        {
            throw new NotImplementedException();
        }

        public CommandResponse CreateTweetFromRequest<T>(T item) where T : class, IAggregate
        {
            // Gets a BookingRequest
            var request = item as TweetRequest;
            var tweet = Adapter.RequestToTweet(request);

            var tweetExists = _cqrsDemoEntities
                .images.FirstOrDefault(r => r.TweetId == tweet.TweetId ||
                r.media_url == tweet.media_url);
            var count = 0;

            if (tweetExists == null)
            {
                _cqrsDemoEntities.images.Add(tweet); //.Set<T>().Add(booking);
                count = _cqrsDemoEntities.SaveChanges();
            }

            var response = new CommandResponse(count > 0, tweet.Id); // { RequestId = new Guid(booking.RequestId) };
            return response;
        }
    }
}
