using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using OAuthTwitterWrapper.JsonTypes;

namespace OAuthTwitterWrapper
{
	class Utility
	{
		public string RequstJson(string apiUrl, string tokenType, string accessToken)
		{
			var json = string.Empty;			
			HttpWebRequest apiRequest = (HttpWebRequest)WebRequest.Create(apiUrl);
			const string timelineHeaderFormat = "{0} {1}";
			apiRequest.Headers.Add("Authorization",
										string.Format(timelineHeaderFormat, tokenType,
													  accessToken));
			apiRequest.Method = "Get";
			WebResponse timeLineResponse = apiRequest.GetResponse();
						
			using (timeLineResponse)
			{
				using (var reader = new StreamReader(timeLineResponse.GetResponseStream()))
				{
					json = reader.ReadToEnd();
					// The below can be used to deserialize into a c# object
					var result = JsonConvert.DeserializeObject<Search>(json);                    
                }
			}
			return json;
		}
    }
}
