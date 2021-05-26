using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Anime
{
    [DependsOn(
        typeof(AnimeApplicationContractsModule)
    )]
    public class AnimeHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AnimeApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
