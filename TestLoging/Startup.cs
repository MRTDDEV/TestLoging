using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestLoging.Startup))]
namespace TestLoging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
