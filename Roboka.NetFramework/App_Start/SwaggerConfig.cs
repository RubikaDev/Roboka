using Roboka.NetFramework;
using Swashbuckle.Application;
using System.Web.Http;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Roboka.NetFramework
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Roboka.NetFramework");
                    c.IncludeXmlComments(string.Format(@"{0}\bin\Roboka.NetFramework.xml", System.AppDomain.CurrentDomain.BaseDirectory));
                    c.DescribeAllEnumsAsStrings();
                })
                .EnableSwaggerUi();
        }
    }
}
