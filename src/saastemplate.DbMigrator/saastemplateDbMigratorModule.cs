using saastemplate.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace saastemplate.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(saastemplateEntityFrameworkCoreDbMigrationsModule),
        typeof(saastemplateApplicationContractsModule)
        )]
    public class saastemplateDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
