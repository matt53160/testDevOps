using Acme.Cvtheque.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.Cvtheque.Permissions;

public class CvthequePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CvthequePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CvthequePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CvthequeResource>(name);
    }
}
