using FluentValidation;
using Garanti.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Application.Validators
{
    public class CreateProductValidator : AbstractValidator<CreateProductRequestDto>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name is required");

            RuleFor(x => x.Price)
                .NotEmpty().
                WithMessage("Price is required");
        }

    }
}
