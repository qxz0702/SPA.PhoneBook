using System.Collections.Generic;
using SPA.PhoneBook.Roles.Dto;
using SPA.PhoneBook.Users.Dto;

namespace SPA.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}

