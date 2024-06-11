using AirFlight2.Web.Models;
using FluentValidation;
using System.Data;

namespace AirFlight2.Web.Validations
{
    public class FlightViewModelValidation :AbstractValidator<FlightViewModel>
    {

        public FlightViewModelValidation()
        {
            RuleFor(x => x.AirPortOriginId).NotNull().NotEmpty().GreaterThan(0).WithMessage("AirPortOrigin not null");

            RuleFor(x => x.AirPortOriginDestinationId).NotNull().NotEmpty().GreaterThan(0).WithMessage("AirPortOriginDestination not null");

            RuleFor(x => x.DateDeparture).Must(GreaterThanNow).WithMessage("DateDeparture date greater today!");

            RuleFor(x => x.DateReturn).Must(GreaterThanNow).WithMessage("DateReturn date greater today!");
        }


        private bool GreaterThanNow(DateTime date) 
        { 
            if (date<DateTime.Now.AddDays(-1))
            {
                return false;
            }
            return true;
        }

    }
}
