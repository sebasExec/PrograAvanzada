using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoPrograAvanzada.Startup))]
namespace ProyectoPrograAvanzada
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
