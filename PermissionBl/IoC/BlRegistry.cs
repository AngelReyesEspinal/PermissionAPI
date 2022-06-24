using System;
using Microsoft.Extensions.DependencyInjection;
using PermissionBl.Repositories;
using PermissionModels.Entities;

namespace PermissionBl.IoC
{
    public static class BlRegistry
    {
        public static void AddBlRegistry(this IServiceCollection services)
        {
            services.AddTransient<IRepositoryBase<Permission>, PermissionRepository>();
            services.AddTransient<IRepositoryBase<PermissionType>, RepositoryBase<PermissionType>>();
        }
    }
}

