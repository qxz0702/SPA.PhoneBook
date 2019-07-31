using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SPA.PhoneBook.MultiTenancy.Dto;

namespace SPA.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


