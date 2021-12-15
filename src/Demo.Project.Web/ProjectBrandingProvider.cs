using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Demo.Project.Web
{
    [Dependency(ReplaceServices = true)]
    public class ProjectBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Project";
    }
}
