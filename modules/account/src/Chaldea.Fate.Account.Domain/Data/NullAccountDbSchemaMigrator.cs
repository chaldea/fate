using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Chaldea.Fate.Account.Data
{
    /* This is used if database provider does't define
     * IAccountDbSchemaMigrator implementation.
     */
    public class NullAccountDbSchemaMigrator : IAccountDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}