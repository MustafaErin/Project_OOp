using Entity_Layer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x=>x.ProductName).NotEmpty().WithMessage("Ürün adı Boş Geçilemez");
            RuleFor(x=>x.ProductName).MinimumLength(3).WithMessage("Ürün adı en az 3 Karakter olmaLıdır");
            RuleFor(x=>x.ProductStock).NotEmpty().WithMessage("Stok Adeti Boş Geçilemez");
            RuleFor(x=>x.ProductPrice).NotEmpty().WithMessage("Fiyat Boş Geçilemez");
        }
    }
}
