using AirFlight2.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace AirFlight2.Api.Controllers
{


    public class AirPortController : CustomBaseController
    {

        private readonly IAirPortService _service;

        public AirPortController(IAirPortService service)
        {
            _service = service;
        } 

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAirPort() 
        {
            return CreateActionResult(await _service.GetAllAsync());
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByCountryIdWithAirPort(int id) 
        {
           
            return CreateActionResult(await _service.GetByCountryIdWithAirPort(id));
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetAirPortbyId(int id) 
        {
            return CreateActionResult(await _service.GetByIdAsync(id));
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByAirPortbyIdWithCountry(int id) 
        {
            return CreateActionResult(await _service.GetByAirPortbyIdWithCountry(id));
        }

    }
}
