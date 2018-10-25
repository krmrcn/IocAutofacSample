using Autofac;
using Autofac.Integration.WebApi;
using IOCAutofac.Services;
using System.Reflection;
using System.Web.Http;

namespace IOCAutoFac.API
{
    public class IocConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<TestService>().AsSelf().InstancePerRequest();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}
