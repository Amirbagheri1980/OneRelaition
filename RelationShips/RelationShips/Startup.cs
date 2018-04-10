using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RelationShips.Startup))]
namespace RelationShips
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
