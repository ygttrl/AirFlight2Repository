using AirFlight2.Core.Services;
using AirFlight2.Dto.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AirFlight2.Api.Controllers
{
    public class SearchController :CustomBaseController
    {

        private readonly ISearchService _service;

        public SearchController(ISearchService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> AvailabilitySearchFlight([FromQuery]SearchRequestDto request) 
        {             
            return CreateActionResult(await _service.GetAvailabilitySearch(request)); 
        }
    }
}
