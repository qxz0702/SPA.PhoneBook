
using AutoMapper;
using SPA.PhoneBook.PhoneBooks.Persons;
using SPA.PhoneBook.PhoneBooks.Persons.Dtos;

namespace SPA.PhoneBook.PhoneBooks.Persons.Mapper
{

	/// <summary>
    /// 配置Person的AutoMapper
    /// </summary>
	internal static class PersonMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Person,PersonListDto>();
            configuration.CreateMap <PersonListDto,Person>();

            configuration.CreateMap <PersonEditDto,Person>();
            configuration.CreateMap <Person,PersonEditDto>();

        }
	}
}
