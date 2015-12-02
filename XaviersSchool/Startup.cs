using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XaviersSchool.Startup))]
namespace XaviersSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
