using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VetPharma.Startup))]
namespace VetPharma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
