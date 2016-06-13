using System.Collections.Generic;
using Newtonsoft.Json;

namespace OAuthTwitterWrapper.JsonTypes
{
    public class Tweets
    {
        [JsonProperty("statuses")]
        public List<TimeLine> Statuses { get; set; }
        [JsonProperty("search_metadata")]
        public SearchMetadata SearchMetadata { get; set; }
    }
}
