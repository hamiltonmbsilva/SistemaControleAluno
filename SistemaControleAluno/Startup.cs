using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaControleAluno.Startup))]
namespace SistemaControleAluno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
