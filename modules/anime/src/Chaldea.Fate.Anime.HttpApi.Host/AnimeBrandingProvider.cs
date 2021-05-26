using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Chaldea.Fate.Anime
{
    [Dependency(ReplaceServices = true)]
    public class AnimeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Anime";
    }
}
