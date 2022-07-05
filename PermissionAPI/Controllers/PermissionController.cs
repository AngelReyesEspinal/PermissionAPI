using System;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PermissionBl.Dtos;
using PermissionBl.Services;
using PermissionModels.Entities;
using PermissionModels.Repositories;

namespace PermissionAPI.Controllers
{
    [Route("api/[controller]")]
    public class PermissionsController : BaseController<Permission, PermissionDto>
    {
        public PermissionsController(IPermissionService permissionService, IValidatorFactory validationFactory, IMapper mapper) : base(permissionService, validationFactory, mapper)
        {
        }
    }
}

