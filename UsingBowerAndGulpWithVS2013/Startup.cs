using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UsingBowerAndGulpWithVS2013.Startup))]
namespace UsingBowerAndGulpWithVS2013
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
