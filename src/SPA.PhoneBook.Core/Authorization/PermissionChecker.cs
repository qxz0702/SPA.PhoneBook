using Abp.Authorization;
using SPA.PhoneBook.Authorization.Roles;
using SPA.PhoneBook.Authorization.Users;

namespace SPA.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

