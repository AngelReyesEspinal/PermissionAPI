using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PermissionBl.Repositories;
using PermissionModels.Entities;

namespace PermissionAPI.Controllers
{
    public class PermissionController : BaseController<Permission>
    {
        public PermissionController(IRepositoryBase<Permission> baseRepository)
            : base(baseRepository)
        {
        }
    }
}

