using System;
using AutoMapper;
using PermissionBl.Dtos;
using PermissionModels.Entities;

namespace PermissionBl.Profiles
{
	public class PermissionProfile : Profile
    {
        public PermissionProfile()
        {
            CreateMap<PermissionType, PermissionTypeDto>();
            CreateMap<PermissionTypeDto, PermissionType>();

            CreateMap<Permission, PermissionDto>()
                .ForMember(y => y.PermissionTypeDescription, x => x.MapFrom(y => y.PermissionType.Description));
            CreateMap<PermissionDto, Permission>();
        }
    }
}

