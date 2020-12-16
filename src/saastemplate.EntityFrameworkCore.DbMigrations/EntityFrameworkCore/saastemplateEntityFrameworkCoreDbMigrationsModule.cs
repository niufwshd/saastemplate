using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace saastemplate.EntityFrameworkCore
{
    [DependsOn(
        typeof(saastemplateEntityFrameworkCoreModule)
        )]
    public class saastemplateEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<saastemplateMigrationsDbContext>();
        }
    }
}
