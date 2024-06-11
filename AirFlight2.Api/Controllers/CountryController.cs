using AirFlight2.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace AirFlight2.Api.Controllers
{
    public class CountryController : CustomBaseController
    {

        private readonly ICountryService _countryService;
        
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCountry()
        {
            return CreateActionResult(await _countryService.GetAllAsync());
        }
         
    }
}
