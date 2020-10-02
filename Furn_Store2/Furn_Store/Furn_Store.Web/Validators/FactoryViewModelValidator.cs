using FluentValidation;
using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.Validators
{
    public class FactoryViewModelValidator : AbstractValidator<FactoryViewModel>
    {
        public FactoryViewModelValidator()
        {
            RuleFor(x => x.name)
               .NotEmpty()
               .MaximumLength(40)
               .WithMessage("Вкажіть назву виробника");
            RuleFor(x => x.country)
                .NotEmpty()
                .MaximumLength(40)
                .WithMessage("Вкажіть країну виробника");
            RuleFor(x => x.description)
                .MaximumLength(1000)
                .WithMessage("Опис може бути не більше 1000 символів");
        }
    }
}
