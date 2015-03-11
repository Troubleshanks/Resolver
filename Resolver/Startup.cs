using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resolver.Startup))]
namespace Resolver
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
