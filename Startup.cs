using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSecurityDemoo.Startup))]
namespace WebSecurityDemoo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
