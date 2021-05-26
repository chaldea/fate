using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Chaldea.Fate.Anime
{
    /* This is used if database provider does't define
     * IAnimeDbSchemaMigrator implementation.
     */
    public class NullAnimeDbSchemaMigrator : IAnimeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}