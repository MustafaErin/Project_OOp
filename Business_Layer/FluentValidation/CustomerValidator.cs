using Entity_Layer.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Müşteri Adı Boş Geçilemez");
            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Müşteri Şehri Boş geçilemez");
        }
    }
}
