using Volo.Abp.Modularity;

namespace saastemplate
{
    [DependsOn(
        typeof(saastemplateApplicationModule),
        typeof(saastemplateDomainTestModule)
        )]
    public class saastemplateApplicationTestModule : AbpModule
    {

    }
}