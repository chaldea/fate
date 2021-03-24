using Volo.Abp.Bundling;

namespace Chaldea.Fate.Account.Blazor
{
    public class AccountBundleContributor : IBundleContributor
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