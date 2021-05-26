using Volo.Abp.Bundling;

namespace Chaldea.Fate.Template.Blazor
{
    public class TemplateBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}