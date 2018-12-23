using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XTest.Startup))]
namespace XTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
