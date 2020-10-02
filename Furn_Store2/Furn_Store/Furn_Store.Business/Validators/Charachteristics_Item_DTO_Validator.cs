using FluentValidation;
using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.Validators
{
    public class Charachteristircs_Item_DTO_Validator : AbstractValidator<Charachteristic_Item_DTO>
    {
        public Charachteristircs_Item_DTO_Validator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.ItemId)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.Length_it)
                .NotEmpty();
            RuleFor(x => x.Height_it)
                .NotEmpty();
            RuleFor(x => x.Width_it)
                .NotEmpty();
        }
    }
}
