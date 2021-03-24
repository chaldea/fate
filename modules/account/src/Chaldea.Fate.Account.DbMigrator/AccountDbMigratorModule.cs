using Chaldea.Fate.Account.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Account.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AccountMongoDbModule),
        typeof(AccountApplicationContractsModule)
        )]
    public class AccountDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
