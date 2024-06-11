using AirFlight2.Dto.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Service.Validations
{
    public class AirPortValidator : AbstractValidator<AirPortDto>
    {
        public AirPortValidator()
        {
            RuleFor(x => x.AirPortName).NotEmpty().WithMessage("AirPortName is not empty!");
        }
    }
}
