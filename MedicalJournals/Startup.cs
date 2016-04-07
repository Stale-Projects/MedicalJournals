using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicalJournals.Startup))]
namespace MedicalJournals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
