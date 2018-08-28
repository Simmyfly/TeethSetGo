using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IEApplication.Startup))]
namespace IEApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
