using System;
using System.Collections.Generic;
using System.Text;
using Chaldea.Fate.Template.Localization;
using Volo.Abp.Application.Services;

namespace Chaldea.Fate.Template
{
    /* Inherit your application services from this class.
     */
    public abstract class TemplateAppService : ApplicationService
    {
        protected TemplateAppService()
        {
            LocalizationResource = typeof(TemplateResource);
        }
    }
}
