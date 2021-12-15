﻿using Demo.Project.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Demo.Project.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ProjectEntityFrameworkCoreModule),
        typeof(ProjectApplicationContractsModule)
        )]
    public class ProjectDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
