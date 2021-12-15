using Demo.Project.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Demo.Project
{
    [DependsOn(
        typeof(ProjectEntityFrameworkCoreTestModule)
        )]
    public class ProjectDomainTestModule : AbpModule
    {

    }
}