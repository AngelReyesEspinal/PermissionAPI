using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Components;
using PermissionBl.Dtos;
using PermissionBl.Services;
using PermissionModels.Entities;
using PermissionModels.Repositories;

namespace PermissionAPI.Controllers
{
    [Route("api/[controller]")]
    public class PermissionTypesController : BaseController<PermissionType, PermissionTypeDto>
    {
        public PermissionTypesController(IPermissionTypeService permissionTypeService, IValidatorFactory validationFactory, IMapper mapper) : base(permissionTypeService, validationFactory, mapper)
        {
        }
    }
}

