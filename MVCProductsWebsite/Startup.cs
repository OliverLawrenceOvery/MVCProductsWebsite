using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(MVCProductsWebsite.Startup))]
namespace MVCProductsWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
