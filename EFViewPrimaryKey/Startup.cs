using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFViewPrimaryKey.Startup))]
namespace EFViewPrimaryKey
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
