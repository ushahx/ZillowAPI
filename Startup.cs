using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZillowAPI1.Startup))]
namespace ZillowAPI1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
