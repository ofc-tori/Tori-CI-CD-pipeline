using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comic_Website.Startup))]
namespace Comic_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
