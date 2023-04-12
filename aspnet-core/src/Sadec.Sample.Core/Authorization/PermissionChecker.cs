using Abp.Authorization;
using Sadec.Sample.Authorization.Roles;
using Sadec.Sample.Authorization.Users;

namespace Sadec.Sample.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
