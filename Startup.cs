using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CdscntMkpAPI_aspnetWebApp.Startup))]
namespace CdscntMkpAPI_aspnetWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
