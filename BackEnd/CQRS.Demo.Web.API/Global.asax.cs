using System.Web.Http;
using CQRS.Demo.Infrastructure.Framework;

namespace CQRS.Demo.Web.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static IBus Bus { get; set; }

        protected void Application_Start()
        {
            BusConfig.Initialize();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
        }
    }
}
