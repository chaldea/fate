using Chaldea.Fate.Account.MongoDB;
using Xunit;

namespace Chaldea.Fate.Account
{
    [CollectionDefinition(AccountTestConsts.CollectionDefinitionName)]
    public class AccountDomainCollection : AccountMongoDbCollectionFixtureBase
    {

    }
}
