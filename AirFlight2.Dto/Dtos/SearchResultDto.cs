using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Dto.Dtos
{
    public class SearchResultDto : BaseDto
    {

        public bool HasError { get; set; }

        public List<FlightOptionDto> FlightOptions { get; set; } = new List<FlightOptionDto>();
    }
}
