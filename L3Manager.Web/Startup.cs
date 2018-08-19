using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L3Manager.Web.Startup))]
namespace L3Manager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
