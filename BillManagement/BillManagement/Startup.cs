using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillManagement.Startup))]
namespace BillManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
