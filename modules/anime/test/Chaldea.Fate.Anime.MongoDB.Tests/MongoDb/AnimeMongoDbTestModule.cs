using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Anime.MongoDB
{
    [DependsOn(
        typeof(AnimeTestBaseModule),
        typeof(AnimeMongoDbModule)
        )]
    public class AnimeMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var stringArray = AnimeMongoDbFixture.ConnectionString.Split('?');
                        var connectionString = stringArray[0].EnsureEndsWith('/')  +
                                                   "Db_" +
                                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
