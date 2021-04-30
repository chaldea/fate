using Chaldea.Fate.Anime.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Chaldea.Fate.Anime.Blazor
{
    public abstract class AnimeComponentBase : AbpComponentBase
    {
        protected AnimeComponentBase()
        {
            LocalizationResource = typeof(AnimeResource);
        }
    }
}
