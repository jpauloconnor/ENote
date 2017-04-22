using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DumbSaint.Web.Startup))]
namespace DumbSaint.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
