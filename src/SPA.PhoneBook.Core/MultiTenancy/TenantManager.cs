using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using SPA.PhoneBook.Authorization.Users;
using SPA.PhoneBook.Editions;

namespace SPA.PhoneBook.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}

