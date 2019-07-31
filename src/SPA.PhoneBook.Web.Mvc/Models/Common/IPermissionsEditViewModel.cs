using System.Collections.Generic;
using SPA.PhoneBook.Roles.Dto;

namespace SPA.PhoneBook.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}
