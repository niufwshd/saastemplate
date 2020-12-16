using saastemplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace saastemplate.Permissions
{
    public class saastemplatePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(saastemplatePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(saastemplatePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<saastemplateResource>(name);
        }
    }
}
