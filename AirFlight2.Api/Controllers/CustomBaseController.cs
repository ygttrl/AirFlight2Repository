using AirFlight2.Dto.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AirFlight2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(ResponceDto<T> responce)
        {
            if (responce.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = responce.StatusCode

                };
            }

            return new ObjectResult(responce)
            {
                StatusCode = responce.StatusCode
            };


        }
    }
}
