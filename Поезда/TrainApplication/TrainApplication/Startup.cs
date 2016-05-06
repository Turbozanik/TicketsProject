using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainApplication.Startup))]
namespace TrainApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
