using System;
using System.Collections.Generic;
using System.Text;
using Chaldea.Fate.Account.Localization;
using Volo.Abp.Application.Services;

namespace Chaldea.Fate.Account
{
    /* Inherit your application services from this class.
     */
    public abstract class AccountAppService : ApplicationService
    {
        protected AccountAppService()
        {
            LocalizationResource = typeof(AccountResource);
        }
    }
}
