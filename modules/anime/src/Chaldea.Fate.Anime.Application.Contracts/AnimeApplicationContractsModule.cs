using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace Chaldea.Fate.Anime
{
    [DependsOn(
        typeof(AnimeDomainSharedModule),
        typeof(AbpObjectExtendingModule)
    )]
    public class AnimeApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            AnimeDtoExtensions.Configure();
        }
    }
}
