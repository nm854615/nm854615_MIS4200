using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nm854615_MIS4200.Startup))]
namespace nm854615_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
