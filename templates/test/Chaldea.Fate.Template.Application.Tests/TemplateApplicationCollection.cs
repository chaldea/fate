using Chaldea.Fate.Template.MongoDB;
using Xunit;

namespace Chaldea.Fate.Template
{
    [CollectionDefinition(TemplateTestConsts.CollectionDefinitionName)]
    public class TemplateApplicationCollection : TemplateMongoDbCollectionFixtureBase
    {

    }
}
