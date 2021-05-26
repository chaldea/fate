using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Anime
{
    [DependsOn(
        typeof(AnimeDomainModule),
        typeof(AnimeApplicationContractsModule)
    )]
    public class AnimeApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AnimeApplicationModule>();
            });
        }
    }
}
