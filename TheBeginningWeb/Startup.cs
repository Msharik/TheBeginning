using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheBeginningWeb.Startup))]
namespace TheBeginningWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
