using Chaldea.Fate.Anime.MongoDB;
using Xunit;

namespace Chaldea.Fate.Anime
{
    [CollectionDefinition(AnimeTestConsts.CollectionDefinitionName)]
    public class AnimeApplicationCollection : AnimeMongoDbCollectionFixtureBase
    {

    }
}
