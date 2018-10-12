using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment1012.Startup))]
namespace Assignment1012
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
