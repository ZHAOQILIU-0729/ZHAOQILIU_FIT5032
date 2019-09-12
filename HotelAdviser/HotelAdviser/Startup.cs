using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HotelAdviser.Startup))]
namespace HotelAdviser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
