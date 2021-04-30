using Chaldea.Fate.Template.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Template.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TemplateMongoDbModule),
        typeof(TemplateApplicationContractsModule)
        )]
    public class TemplateDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
