using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PleaseRememberMeWeb.Startup))]
namespace PleaseRememberMeWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
