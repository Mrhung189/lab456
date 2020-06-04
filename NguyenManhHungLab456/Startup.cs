using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenManhHungLab456.Startup))]
namespace NguyenManhHungLab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
