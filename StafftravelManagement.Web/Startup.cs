using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StafftravelManagement.Web.Startup))]
namespace StafftravelManagement.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
