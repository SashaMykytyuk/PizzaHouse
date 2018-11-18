using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PizzaHouse.Startup))]
namespace PizzaHouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
