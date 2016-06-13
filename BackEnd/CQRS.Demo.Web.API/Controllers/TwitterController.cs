using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using CQRS.Demo.Web.API.Application;
using Newtonsoft.Json;
using OAuthTwitterWrapper;


namespace CQRS.Demo.Web.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TwitterController : ApiController
    {
        private readonly IOAuthTwitterWrapper _oAuthTwitterWrapper = new OAuthTwitterWrapper.OAuthTwitterWrapper();
        private readonly TweetsService _service = new TweetsService();

        public string Get()
        {
            var images = _service.GetImages().OrderByDescending(r=> r.Id);

            return JsonConvert.SerializeObject(images);
        }

        public string Get(string query)
        {            
            var result = _oAuthTwitterWrapper.GetSearchObject(query);

            _service.AddImages(result);

            return JsonConvert.SerializeObject(result);            
        }        
    }
}
