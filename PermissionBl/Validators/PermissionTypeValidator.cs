using System;
using FluentValidation;
using PermissionBl.Dtos;

namespace PermissionBl.Validators
{
    public class PermissionTypeValidator : AbstractValidator<PermissionTypeDto>
    {
        public PermissionTypeValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                    .WithMessage("Description is required");
        }
    }
}

