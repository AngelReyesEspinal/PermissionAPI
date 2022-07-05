using Microsoft.EntityFrameworkCore;
using PermissionModels.Context;
using PermissionModels.Entities;

namespace PermissionModels.Repositories
{
    public class PermissionRepository : RepositoryBase<Permission>
    {
        public PermissionRepository(PermissionDbContext context) : base(context)
        {
        }

        public override IQueryable<Permission> GetAll()
        {
            return base.GetAll().Include(x => x.PermissionType);
        }
    }
}

