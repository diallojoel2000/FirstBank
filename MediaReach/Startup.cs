using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaReach.Startup))]
namespace MediaReach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
