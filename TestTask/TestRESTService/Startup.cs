using System;
using System.Web.Http;
using Owin;
using System.Reflection;

namespace TestRESTService
{
    public class Startup
    {
        // Настраиваем Web API
        public void Configuration(IAppBuilder appBuilder)
        {
            // Конфигурация Web API
            // Маршрутизация
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);
        }
    }
}