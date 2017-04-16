using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CouldMvc.Startup))]
namespace CouldMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
