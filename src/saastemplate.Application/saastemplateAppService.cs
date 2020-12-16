using System;
using System.Collections.Generic;
using System.Text;
using saastemplate.Localization;
using Volo.Abp.Application.Services;

namespace saastemplate
{
    /* Inherit your application services from this class.
     */
    public abstract class saastemplateAppService : ApplicationService
    {
        protected saastemplateAppService()
        {
            LocalizationResource = typeof(saastemplateResource);
        }
    }
}
