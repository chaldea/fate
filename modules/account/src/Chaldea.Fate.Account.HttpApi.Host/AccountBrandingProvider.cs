﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Chaldea.Fate.Account
{
    [Dependency(ReplaceServices = true)]
    public class AccountBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Account";
    }
}
