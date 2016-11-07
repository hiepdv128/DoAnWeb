using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hocvathi_xemdiem.Startup))]
namespace Hocvathi_xemdiem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
