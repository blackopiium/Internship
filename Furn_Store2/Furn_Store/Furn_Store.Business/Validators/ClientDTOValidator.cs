using FluentValidation;
using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.Validators
{
    public class ClientDTOValidator : AbstractValidator<ClientDTO>
    {
        public ClientDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.LastName)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(x => x.MiddleName)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(x => x.Phone_Number)
                .MaximumLength(13)
                .Matches(@"^\+?3?8?(0\d{9}$");
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
        }
    }
    }
