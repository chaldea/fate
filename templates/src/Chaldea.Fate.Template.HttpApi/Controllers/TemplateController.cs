using Chaldea.Fate.Template.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Chaldea.Fate.Template.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TemplateController : AbpController
    {
        protected TemplateController()
        {
            LocalizationResource = typeof(TemplateResource);
        }
    }
}