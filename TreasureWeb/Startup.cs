using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TreasureWeb.Startup))]
namespace TreasureWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
