using Chaldea.Fate.Anime.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Chaldea.Fate.Anime.Permissions
{
    public class AnimePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AnimePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AnimePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AnimeResource>(name);
        }
    }
}
