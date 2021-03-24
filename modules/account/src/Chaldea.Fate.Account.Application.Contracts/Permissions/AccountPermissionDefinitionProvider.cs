using Chaldea.Fate.Account.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Chaldea.Fate.Account.Permissions
{
    public class AccountPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AccountPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AccountPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AccountResource>(name);
        }
    }
}
