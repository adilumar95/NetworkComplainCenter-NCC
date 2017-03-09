using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetworkComplainCenter_NCC.Startup))]
namespace NetworkComplainCenter_NCC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
