using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebPanel.Startup))]
namespace WebPanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
