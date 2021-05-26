using System.Threading.Tasks;

namespace Chaldea.Fate.Anime
{
    public interface IAnimeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
