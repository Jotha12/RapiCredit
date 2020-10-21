using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RapiCredit.Startup))]
namespace RapiCredit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
