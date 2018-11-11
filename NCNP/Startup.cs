using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NCNP.Startup))]
namespace NCNP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
