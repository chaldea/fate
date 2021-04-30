using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Chaldea.Fate.Anime
{
    public class AnimeDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Anime, Guid> _animeRepository;
        private readonly IRepository<Bangumi, Guid> _bangumiRepository;
        private readonly IRepository<Favorite, Guid> _favoriteRepository;

        public AnimeDataSeedContributor(
            IRepository<Anime, Guid> animeRepository, 
            IRepository<Bangumi, Guid> bangumiRepository,
            IRepository<Favorite, Guid> favoriteRepository)
        {
            _animeRepository = animeRepository;
            _bangumiRepository = bangumiRepository;
            _favoriteRepository = favoriteRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await Task.CompletedTask;
        }
    }
}