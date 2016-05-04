using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleInjectorSetup.Startup))]
namespace SimpleInjectorSetup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
