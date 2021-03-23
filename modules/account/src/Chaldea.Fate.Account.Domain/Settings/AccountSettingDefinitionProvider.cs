using Volo.Abp.Settings;

namespace Chaldea.Fate.Account.Settings
{
    public class AccountSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AccountSettings.MySetting1));
        }
    }
}
