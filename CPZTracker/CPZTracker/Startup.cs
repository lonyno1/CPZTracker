using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CPZTracker.Startup))]
namespace CPZTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
