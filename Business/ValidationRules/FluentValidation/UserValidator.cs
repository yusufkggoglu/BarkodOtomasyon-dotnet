using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ad  boş olamaz !");
            RuleFor(p => p.Role).NotEmpty().WithMessage("Kullanıcı bir Rol'e bağlı olmalı !");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre boş olamaz !");
            RuleFor(p => p.Password).Length(1, 6).WithMessage("Şifre en uzun 6 haneli olmalı !");
        }
    }
}
