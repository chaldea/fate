using Chaldea.Fate.Account.MongoDB;
using Volo.Abp.Modularity;

namespace Chaldea.Fate.Account
{
    [DependsOn(
        typeof(AccountMongoDbTestModule)
        )]
    public class AccountDomainTestModule : AbpModule
    {

    }
}