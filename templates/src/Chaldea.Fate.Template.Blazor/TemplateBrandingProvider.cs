using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Chaldea.Fate.Template.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class TemplateBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Template";
    }
}
