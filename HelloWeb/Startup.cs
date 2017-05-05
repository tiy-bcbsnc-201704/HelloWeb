using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWeb.Startup))]
namespace HelloWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
