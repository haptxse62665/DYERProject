using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DYER.Startup))]
namespace DYER
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
