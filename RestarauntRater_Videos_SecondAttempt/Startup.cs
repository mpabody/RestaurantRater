using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestarauntRater_Videos_SecondAttempt.Startup))]
namespace RestarauntRater_Videos_SecondAttempt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
