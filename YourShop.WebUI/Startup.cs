using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YourShop.WebUI.Startup))]
namespace YourShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
