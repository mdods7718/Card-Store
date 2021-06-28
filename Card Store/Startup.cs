using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Card_Store.Startup))]
namespace Card_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
