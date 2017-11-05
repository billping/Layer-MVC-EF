using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THY.UI.Startup))]
namespace THY.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
