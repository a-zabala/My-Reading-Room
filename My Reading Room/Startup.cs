using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My_Reading_Room.Startup))]
namespace My_Reading_Room
{
    public partial class Startup
    {
        //hello
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
