using Microsoft.Extensions.DependencyInjection;
using PermissionModels.Repositories;
using PermissionModels.Entities;

namespace PermissionModels.IoC
{
    public static class ModelRegistry
    {
        public static void AddModelRegistry(this IServiceCollection services)
        {
            services.AddTransient<IRepositoryBase<Permission>, RepositoryBase<Permission>>();
            services.AddTransient<IRepositoryBase<PermissionType>, RepositoryBase<PermissionType>>();
        }
    }
}
