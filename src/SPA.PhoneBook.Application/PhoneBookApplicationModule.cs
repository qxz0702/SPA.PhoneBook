using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SPA.PhoneBook.Authorization;
using SPA.PhoneBook.PhoneBooks.Persons.Authorization;
using SPA.PhoneBook.PhoneBooks.Persons.Mapper;

namespace SPA.PhoneBook
{
    [DependsOn(
        typeof(PhoneBookCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PhoneBookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PhoneBookAuthorizationProvider>();
            Configuration.Authorization.Providers.Add<PersonAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                PersonMapper.CreateMappings(configuration);
            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PhoneBookApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

