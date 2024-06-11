using AirFlight2.Dto.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Service.Validations
{
    public class CountryDtoValidation : AbstractValidator<CountryDto>
    {
        public CountryDtoValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Counry is not empty!");
        }
    }
}
