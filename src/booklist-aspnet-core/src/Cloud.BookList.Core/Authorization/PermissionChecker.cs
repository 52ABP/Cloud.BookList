using Abp.Authorization;
using Cloud.BookList.Authorization.Roles;
using Cloud.BookList.Authorization.Users;

namespace Cloud.BookList.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
