using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THY.Web.Startup))]
namespace THY.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
