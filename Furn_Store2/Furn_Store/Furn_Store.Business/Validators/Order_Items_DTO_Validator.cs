using FluentValidation;
using Furn_Store.Business.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Business.Validators
{
    public class Order_Items_DTO_Validator : AbstractValidator<Order_Items_DTO>
    {
        public Order_Items_DTO_Validator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.ItemId)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.OrderId)
                .NotEmpty()
                .GreaterThan(0);
            RuleFor(x => x.Count_of_items)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}

