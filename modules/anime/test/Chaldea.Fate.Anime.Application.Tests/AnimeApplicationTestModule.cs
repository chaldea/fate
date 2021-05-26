using Volo.Abp.Modularity;

namespace Chaldea.Fate.Anime
{
    [DependsOn(
        typeof(AnimeApplicationModule),
        typeof(AnimeDomainTestModule)
        )]
    public class AnimeApplicationTestModule : AbpModule
    {

    }
}