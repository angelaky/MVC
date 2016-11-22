using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MathBlog.Startup))]
namespace MathBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
