using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnBootstrap.Startup))]
namespace LearnBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
