using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(serwis.Startup))]
namespace serwis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
