using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WisestJobMasters.Startup))]
namespace WisestJobMasters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
