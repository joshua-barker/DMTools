using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMTools.Startup))]
namespace DMTools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
