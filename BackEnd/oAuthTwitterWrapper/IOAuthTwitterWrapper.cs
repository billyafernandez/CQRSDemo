using System;
using OAuthTwitterWrapper.JsonTypes;

namespace OAuthTwitterWrapper
{
	public interface IOAuthTwitterWrapper
	{
		string GetMyTimeline();
		string GetSearchJson(string query);
        Search GetSearchObject(string query);
    }
}
