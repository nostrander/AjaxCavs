using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxCavs.Startup))]
namespace AjaxCavs
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
