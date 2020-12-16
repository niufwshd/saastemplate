using saastemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace saastemplate.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class saastemplateController : AbpController
    {
        protected saastemplateController()
        {
            LocalizationResource = typeof(saastemplateResource);
        }
    }
}