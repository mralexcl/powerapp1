using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PowerAPP1.Startup))]
namespace PowerAPP1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
