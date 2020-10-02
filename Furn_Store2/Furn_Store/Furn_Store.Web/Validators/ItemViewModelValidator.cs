using FluentValidation;
using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.Validators
{
    public class ItemViewModelValidator : AbstractValidator<ItemViewModel>
    {
        public ItemViewModelValidator()
        {
            RuleFor(x => x.name)
                .NotEmpty()
                .MaximumLength(30)
                .WithMessage("Вкажіть назву");
            RuleFor(x => x.price)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Вкажіть ціну більше 0");
            RuleFor(x => x.description)
                .NotEmpty()
                .MaximumLength(1000)
                .WithMessage("Опис товару може бути не більше 1000 символів");
        }
    }
}
