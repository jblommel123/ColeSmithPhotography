using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ColeSmithPhotographyApp.Startup))]
namespace ColeSmithPhotographyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
