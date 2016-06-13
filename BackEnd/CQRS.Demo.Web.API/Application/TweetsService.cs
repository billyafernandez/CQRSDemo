using System;
using System.Collections.Generic;
using System.Linq;
using CQRS.Demo.CommandStack.Commands;
using CQRS.Demo.Infrastructure.Persistence.SqlServer;
using CQRS.Demo.QueryStack.DataAccess;
using OAuthTwitterWrapper.JsonTypes;

namespace CQRS.Demo.Web.API.Application
{
    public class TweetsService
    {
        #region Command stack endpoints
        public void AddImages(Search tweets)
        {
            foreach (var result in tweets.Results)
            {
                if (result.entities.Media != null &&
                    (result.possibly_sensitive == null || result.possibly_sensitive == false))
                {
                    foreach (var media in result.entities.Media)
                    {
                        var command = new RequestTweetCommand(
                            result.id_str,
                            result.Text,
                            media.media_url);

                        WebApiApplication.Bus.Send(command);
                    }
                }
            }
            
        }
        #endregion

        #region Query stack endpoints
        public IEnumerable<images> GetImages()
        {
            var db = new Database();
            var images = (from i in db.Images select i);

            return images;
        }
        #endregion
    }
}