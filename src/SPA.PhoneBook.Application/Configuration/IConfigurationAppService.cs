using System.Threading.Tasks;
using SPA.PhoneBook.Configuration.Dto;

namespace SPA.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

