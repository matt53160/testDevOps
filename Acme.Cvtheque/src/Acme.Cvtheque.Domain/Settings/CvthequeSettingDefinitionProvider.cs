using Volo.Abp.Settings;

namespace Acme.Cvtheque.Settings;

public class CvthequeSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CvthequeSettings.MySetting1));
    }
}
