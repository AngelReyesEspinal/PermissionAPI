using System;
using PermissionBl.Repositories;
using PermissionModels.Entities;

namespace PermissionAPI.Controllers
{
	public class PermissionTypeController : BaseController<PermissionType>
    {
        public PermissionTypeController(IRepositoryBase<PermissionType> baseRepository)
            : base(baseRepository)
        {
        }
    }
}

