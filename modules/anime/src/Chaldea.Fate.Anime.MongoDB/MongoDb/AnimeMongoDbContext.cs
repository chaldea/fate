using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Chaldea.Fate.Anime.MongoDB
{
    [ConnectionStringName("Default")]
    public class AnimeMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<Bangumi> Bangumis => Collection<Bangumi>();
        public IMongoCollection<Anime> Animes => Collection<Anime>();
        public IMongoCollection<Favorite> Favorites => Collection<Favorite>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);
        }
    }
}
