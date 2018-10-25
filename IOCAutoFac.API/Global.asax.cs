using System.Web;
using System.Web.Http;

namespace IOCAutoFac.API
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            IocConfig.Configure();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
