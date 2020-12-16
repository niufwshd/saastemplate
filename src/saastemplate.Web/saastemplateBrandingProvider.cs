using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace saastemplate.Web
{
    [Dependency(ReplaceServices = true)]
    public class saastemplateBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "saastemplate";
    }
}
