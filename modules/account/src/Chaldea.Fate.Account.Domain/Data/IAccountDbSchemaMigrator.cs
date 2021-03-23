using System.Threading.Tasks;

namespace Chaldea.Fate.Account.Data
{
    public interface IAccountDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
