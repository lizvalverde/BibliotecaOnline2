using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebBibliotecaOnline2.Startup))]
namespace WebBibliotecaOnline2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
