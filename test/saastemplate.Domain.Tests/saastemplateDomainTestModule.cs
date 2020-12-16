using saastemplate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace saastemplate
{
    [DependsOn(
        typeof(saastemplateEntityFrameworkCoreTestModule)
        )]
    public class saastemplateDomainTestModule : AbpModule
    {

    }
}