using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpectraBlog.Web.Startup))]
namespace SpectraBlog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
