using System;
using Microsoft.Extensions.DependencyInjection;
using PermissionBl.Services;

namespace PermissionBl.IoC
{
    public static class ServicesRegistry
    {
        public static void AddServicesRegistry(this IServiceCollection services)
        {
            services.AddTransient<IPermissionService, PermissionService>();
            services.AddTransient<IPermissionTypeService, PermissionTypeService>();
        }
    }
}

