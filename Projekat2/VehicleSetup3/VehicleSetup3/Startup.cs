using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleSetup3.Startup))]
namespace VehicleSetup3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
