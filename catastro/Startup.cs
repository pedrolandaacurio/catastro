using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(catastro.Startup))]
namespace catastro
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
