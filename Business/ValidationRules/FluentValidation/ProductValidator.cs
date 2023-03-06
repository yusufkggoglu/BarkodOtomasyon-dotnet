using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün ismi boş olamaz !");
            RuleFor(p => p.PurchasePrice).NotEmpty().WithMessage("Ürün fiyatsız olamaz !");
            RuleFor(p => p.SalePrice).NotEmpty().WithMessage("Ürün fiyatsız olamaz !");
            RuleFor(p => p.SalePrice).GreaterThan(p => p.PurchasePrice).WithMessage("Satış fiyatı ürünün geliş fiyatından yüksek olmalı !");
            RuleFor(p => p.StockAmount).NotEmpty().WithMessage("Miktar 0 veya 0'dan küçük olamaz !");
            RuleFor(p => p.SalePrice).GreaterThan(0).WithMessage("Fiyat 0 veya 0'dan küçük olamaz !");
            RuleFor(p => p.PurchasePrice).GreaterThan(0).WithMessage("Fiyat 0 veya 0'dan küçük olamaz !");
        }
    }
}