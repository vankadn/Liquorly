using Microsoft.Owin;
using Owin;
using Liqourly;

[assembly: OwinStartup(typeof(Startup))]
namespace Liqourly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
