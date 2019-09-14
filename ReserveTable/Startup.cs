using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReserveTable.Startup))]
namespace ReserveTable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
