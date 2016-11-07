using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hocvathi_hienthidiemthi.Startup))]
namespace Hocvathi_hienthidiemthi
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
