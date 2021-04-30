using Volo.Abp.Modularity;

namespace Chaldea.Fate.Anime
{
    [DependsOn(
        typeof(AnimeDomainSharedModule)
    )]
    public class AnimeDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}