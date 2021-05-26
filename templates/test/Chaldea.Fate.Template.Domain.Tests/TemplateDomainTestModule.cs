using Chaldea.Fate.Template.MongoDB;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Template
{
    [DependsOn(
        typeof(TemplateMongoDbTestModule)
        )]
    public class TemplateDomainTestModule : AbpModule
    {

    }
}