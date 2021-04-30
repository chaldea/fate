using Chaldea.Fate.Anime.MongoDB;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Anime
{
    [DependsOn(
        typeof(AnimeMongoDbTestModule)
        )]
    public class AnimeDomainTestModule : AbpModule
    {

    }
}