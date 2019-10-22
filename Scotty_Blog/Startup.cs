using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Scotty_Blog.Startup))]
namespace Scotty_Blog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
