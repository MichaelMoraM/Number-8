using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Number8.Startup))]
namespace Number8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
