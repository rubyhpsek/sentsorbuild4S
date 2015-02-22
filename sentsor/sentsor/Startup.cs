using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sentsor.Startup))]
namespace sentsor
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
