using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCResearch.Startup))]
namespace MVCResearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
