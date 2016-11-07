using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hocvathi_gopy.Startup))]
namespace Hocvathi_gopy
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
