using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RoleValidator : AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Rol ismi  boş olamaz !");
            RuleFor(p => p.AdminStatus).NotEmpty().WithMessage("Admin Yetkisi boş olamaz !");
        }
    }
}
