using Chaldea.Fate.Template.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Chaldea.Fate.Template.Blazor
{
    public abstract class TemplateComponentBase : AbpComponentBase
    {
        protected TemplateComponentBase()
        {
            LocalizationResource = typeof(TemplateResource);
        }
    }
}
