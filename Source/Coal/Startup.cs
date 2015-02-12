using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coal.Startup))]
namespace Coal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
