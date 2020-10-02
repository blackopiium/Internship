using FluentValidation;
using Furn_Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Furn_Store.Web.Validators
{
    public class LoginViewModelValidator : AbstractValidator<LoginViewModel>
    {
        public LoginViewModelValidator()
        {
            RuleFor(x => x.username)
                .NotEmpty();
            RuleFor(x => x.password)
                .NotEmpty();
        }
    }
}
