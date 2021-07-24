using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PR.Startup))]
namespace PR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
