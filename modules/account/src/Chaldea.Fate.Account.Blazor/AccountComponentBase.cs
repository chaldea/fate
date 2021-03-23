using Chaldea.Fate.Account.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Chaldea.Fate.Account.Blazor
{
    public abstract class AccountComponentBase : AbpComponentBase
    {
        protected AccountComponentBase()
        {
            LocalizationResource = typeof(AccountResource);
        }
    }
}
