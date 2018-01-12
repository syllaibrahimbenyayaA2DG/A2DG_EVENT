using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A2DGEvent.Startup))]
namespace A2DGEvent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
