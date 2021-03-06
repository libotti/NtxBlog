﻿using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using NtxBlog.Authorization.Roles;
using NtxBlog.Editions;
using NtxBlog.Users;

namespace NtxBlog.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}