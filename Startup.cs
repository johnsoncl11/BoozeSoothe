using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoozeSoothe.Startup))]
namespace BoozeSoothe
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
