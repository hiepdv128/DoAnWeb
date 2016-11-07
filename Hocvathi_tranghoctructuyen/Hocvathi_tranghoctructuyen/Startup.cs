using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hocvathi_tranghoctructuyen.Startup))]
namespace Hocvathi_tranghoctructuyen
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
