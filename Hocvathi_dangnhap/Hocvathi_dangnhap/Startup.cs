using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hocvathi_dangnhap.Startup))]
namespace Hocvathi_dangnhap
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
