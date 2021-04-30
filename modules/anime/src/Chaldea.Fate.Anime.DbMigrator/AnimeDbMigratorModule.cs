using Chaldea.Fate.Anime.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Anime.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AnimeMongoDbModule),
        typeof(AnimeApplicationContractsModule)
        )]
    public class AnimeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
