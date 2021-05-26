using Chaldea.Fate.Anime.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Chaldea.Fate.Anime
{
    public class AnimeDomainSharedModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            AnimeGlobalFeatureConfigurator.Configure();
            AnimeModuleExtensionConfigurator.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AnimeDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<AnimeResource>("en")
                    // .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Anime");

                options.DefaultResourceType = typeof(AnimeResource);
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Anime", typeof(AnimeResource));
            });
        }
    }
}
