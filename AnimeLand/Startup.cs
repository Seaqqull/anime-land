using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnimeLand.Startup))]
namespace AnimeLand
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
