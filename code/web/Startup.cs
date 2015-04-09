using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(norpim.mvc.Startup))]
namespace norpim.mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
