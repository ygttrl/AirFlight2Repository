using AirFlight2.Dto.Dtos;
using AirFlight2.Web.Models;
using AirFlight2.Web.Services;
using AirFlight2.Web.Validations;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AirFlight2.Web.Controllers
{
    public class FlightController : Controller
    {
        private readonly CountryApiService _countryApiService;
        private readonly AirPortApiService _airPortApiService;
        private readonly SearchApiService _searchApiService; 

        public FlightController(CountryApiService countryApiService, AirPortApiService airPortApiService, SearchApiService searchApiService)
        {
            _countryApiService = countryApiService;
            _airPortApiService = airPortApiService;
            _searchApiService = searchApiService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var datas = _countryApiService.GetAllCountry();
            var flightView = new FlightViewModel();
            flightView.Countries = new SelectList(datas.Result, "Id", "Name");

            return View(flightView);
        }

        [HttpPost]
        public IActionResult Index(FlightViewModel model)
        {
            var datas = _countryApiService.GetAllCountry(); 
            model.Countries = new SelectList(datas.Result, "Id", "Name"); 

             FlightViewModelValidation FlghtValidation = new FlightViewModelValidation();
             ValidationResult result = FlghtValidation.Validate(model); 

            if (result.IsValid)
            {
                return RedirectToAction("FlightDetail", "Flight", model);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("",item.ErrorMessage);
                }
                return View(model);
            }  
        }


        [HttpPost]
        public async Task<JsonResult> GetAirportsByCountryId(int id)
        {
            var datas = await _airPortApiService.GetAirPortsWithCountryId(id);

            return Json(datas);
        }

        [HttpGet]
        public async Task<IActionResult> FlightDetail(FlightViewModel model)
        {

            var airPortOrigin = await _airPortApiService.GetByAirPortbyIdWithCountry(model.AirPortOriginId);
            var airPortDestaniation = await _airPortApiService.GetByAirPortbyIdWithCountry(model.AirPortOriginDestinationId);

            SearchRequestDto searchRequestDto = new()
            {
                Origin = airPortOrigin.AirPortName,
                Destination = airPortDestaniation.AirPortName,
                DepartureDate = model.DateDeparture
            };


            var resultFlights = await _searchApiService.AvailabilitySearch(searchRequestDto);

            if (resultFlights.FlightOptions.Count > 0)
            {
                foreach (var item in resultFlights.FlightOptions)
                {
                    var FlightNumber = item.FlightNumber;
                    var DepartureDateTime = item.DepartureDateTime;
                    var ArrivalDateTime = item.ArrivalDateTime;
                    var Price = item.Price;
                }
            }

            var flightDetails = new FlightDetailViewModel
            {
                AirPortOrigin = searchRequestDto.Origin,
                CountryOrigin= airPortOrigin.Country.Name,
                AirPortDestination = searchRequestDto.Destination,
                CountryDestination=airPortDestaniation.Country.Name,
                HasError = resultFlights.HasError,
                FlightOptions = resultFlights.FlightOptions,
            }; 

            return View(flightDetails);
        }
    }
}
