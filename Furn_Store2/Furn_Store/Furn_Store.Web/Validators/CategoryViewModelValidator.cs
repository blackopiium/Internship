using FluentValidation;
using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.Validators
{
    public class CategoryViewModelValidator : AbstractValidator<CategoryViewModel>
    {
        public CategoryViewModelValidator()
        {
            RuleFor(x => x.name)
               .NotEmpty()
               .MaximumLength(40)
               .WithMessage("Вкажіть ім'я");
            RuleFor(x => x.description)
                .MaximumLength(1000)
                .WithMessage("Опис може бути не більше 1000 символів");
        }
    }
}
