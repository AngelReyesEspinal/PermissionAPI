using System;
using FluentValidation;
using PermissionModels.Entities;

namespace PermissionBl.Validators
{
    public class PermissionTypeValidator : AbstractValidator<PermissionType>
    {
        public PermissionTypeValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                    .WithMessage("Description is required");
        }
    }
}

