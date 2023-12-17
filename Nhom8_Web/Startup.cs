using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nhom8_Web.Startup))]
namespace Nhom8_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
