using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductsBackend.Startup))]
namespace ProductsBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
