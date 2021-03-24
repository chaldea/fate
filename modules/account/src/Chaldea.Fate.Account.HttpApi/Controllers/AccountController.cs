using Chaldea.Fate.Account.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Chaldea.Fate.Account.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AccountController : AbpController
    {
        protected AccountController()
        {
            LocalizationResource = typeof(AccountResource);
        }
    }
}