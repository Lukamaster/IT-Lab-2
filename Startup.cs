using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_Lab_2.Startup))]
namespace IT_Lab_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
