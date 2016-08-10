using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bodega.Startup))]
namespace Bodega
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
