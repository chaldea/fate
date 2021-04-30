using Volo.Abp.Modularity;

namespace Chaldea.Fate.Template
{
    [DependsOn(
        typeof(TemplateApplicationModule),
        typeof(TemplateDomainTestModule)
        )]
    public class TemplateApplicationTestModule : AbpModule
    {

    }
}