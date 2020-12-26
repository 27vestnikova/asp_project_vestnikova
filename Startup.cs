using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PolinaVestnikova.Startup))]
namespace PolinaVestnikova
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
