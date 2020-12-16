using Volo.Abp.Settings;

namespace saastemplate.Settings
{
    public class saastemplateSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(saastemplateSettings.MySetting1));
        }
    }
}
