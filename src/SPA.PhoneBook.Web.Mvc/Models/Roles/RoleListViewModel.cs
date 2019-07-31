﻿using System.Collections.Generic;
using SPA.PhoneBook.Roles.Dto;

namespace SPA.PhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}

