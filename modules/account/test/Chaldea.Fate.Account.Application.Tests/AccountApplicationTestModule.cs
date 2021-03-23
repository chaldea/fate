using Volo.Abp.Modularity;

namespace Chaldea.Fate.Account
{
    [DependsOn(
        typeof(AccountApplicationModule),
        typeof(AccountDomainTestModule)
        )]
    public class AccountApplicationTestModule : AbpModule
    {

    }
}