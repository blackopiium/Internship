using FluentValidation;
using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.Validators
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(x => x.userName)
                .NotEmpty()
                .WithMessage("Введіть свій username");
            RuleFor(x => x.email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Введіть свою поштову адресу");
            RuleFor(x => x.password)
                .NotEmpty()
                .WithMessage("Введіть пароль");
        }
    }
}
