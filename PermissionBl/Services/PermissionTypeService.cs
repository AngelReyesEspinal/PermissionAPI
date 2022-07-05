using System;
using AutoMapper;
using FluentValidation;
using PermissionBl.Dtos;
using PermissionModels.Entities;
using PermissionModels.Repositories;

namespace PermissionBl.Services
{
    public interface IPermissionTypeService : IBaseService<PermissionType, PermissionTypeDto>
    {
    }

    public class PermissionTypeService : BaseService<PermissionType, PermissionTypeDto>, IPermissionTypeService
    {
        public PermissionTypeService(IMapper mapper, IValidator<PermissionTypeDto> validator, IRepositoryBase<PermissionType> baseRepository) : base(mapper, validator, baseRepository)
        {

        }
    }
}

