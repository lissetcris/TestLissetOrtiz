using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba_LissetOrtiz.Startup))]
namespace Prueba_LissetOrtiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
