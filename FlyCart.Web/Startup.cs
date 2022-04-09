using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlyCart.Web.Startup))]
namespace FlyCart.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
