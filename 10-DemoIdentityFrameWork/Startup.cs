using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_10_DemoIdentityFrameWork.Startup))]
namespace _10_DemoIdentityFrameWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
