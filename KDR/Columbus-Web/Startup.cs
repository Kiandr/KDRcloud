using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kiandr.Startup))]
namespace kiandr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
