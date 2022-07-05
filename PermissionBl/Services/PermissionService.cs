using System;
using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PermissionBl.Dtos;
using PermissionModels.Entities;
using PermissionModels.Repositories;

namespace PermissionBl.Services
{
    public interface IPermissionService : IBaseService<Permission, PermissionDto>
    {
    }

    public class PermissionService : BaseService<Permission, PermissionDto>, IPermissionService
    {
        public PermissionService(IMapper mapper, IValidator<PermissionDto> validator, IRepositoryBase<Permission> baseRepository) : base(mapper, validator, baseRepository)
        {

        }

        public override IList<PermissionDto> GetAll()
        {
            var list = _repository.GetAll().Include(x => x.PermissionType).ToList();
            IList<PermissionDto> listDto = _mapper.Map<IList<PermissionDto>>(list);
            return listDto;
        }
    }
}

