using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FlowerLove.Startup))]
namespace FlowerLove
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
