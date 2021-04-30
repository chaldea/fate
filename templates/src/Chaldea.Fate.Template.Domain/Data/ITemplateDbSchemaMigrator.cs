using System.Threading.Tasks;

namespace Chaldea.Fate.Template.Data
{
    public interface ITemplateDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
