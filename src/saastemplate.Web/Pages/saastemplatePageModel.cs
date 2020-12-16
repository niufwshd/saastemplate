using saastemplate.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace saastemplate.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class saastemplatePageModel : AbpPageModel
    {
        protected saastemplatePageModel()
        {
            LocalizationResourceType = typeof(saastemplateResource);
        }
    }
}