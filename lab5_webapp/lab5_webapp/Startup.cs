using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab5_webapp.Startup))]
namespace lab5_webapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
