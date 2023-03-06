using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class IncomeValidator : AbstractValidator<Income>
    {
        public IncomeValidator()
        {
            RuleFor(p => p.PaymentMethod).NotEmpty().WithMessage("Gider ödeme yöntemi boş olamaz !");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Gider adet fiyatı boş olamaz !");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Gider ismi  boş olamaz !");
            RuleFor(p => p.Amount).NotEmpty().WithMessage("Miktar boş olamaz !");
            RuleFor(p => p.Date).NotEmpty().WithMessage("Gider tarihi boş olamaz !");

            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Fiyat 0 veya 0'dan küçük olamaz !");
            RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Miktar 0 veya 0'dan küçük olamaz !");
        }
    }
}
