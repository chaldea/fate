using Chaldea.Fate.Anime.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Chaldea.Fate.Anime.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AnimeController : AbpController
    {
        protected AnimeController()
        {
            LocalizationResource = typeof(AnimeResource);
        }
    }
}