using System.Threading.Tasks;
using Abp.Application.Services;
using SPA.PhoneBook.Sessions.Dto;

namespace SPA.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

