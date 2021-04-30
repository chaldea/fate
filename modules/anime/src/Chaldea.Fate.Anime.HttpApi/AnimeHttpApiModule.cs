using Chaldea.Fate.Anime.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Anime
{
    [DependsOn(
        typeof(AnimeApplicationContractsModule)
    )]
    public class AnimeHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureLocalization();
        }

        private void ConfigureLocalization()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AnimeResource>();
            });
        }
    }
}
