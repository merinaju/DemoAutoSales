using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoAutoSales.Startup))]
namespace DemoAutoSales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
