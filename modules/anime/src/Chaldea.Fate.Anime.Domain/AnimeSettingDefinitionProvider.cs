using Volo.Abp.Settings;

namespace Chaldea.Fate.Anime
{
    public class AnimeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AnimeSettings.MySetting1));
        }
    }
}
