using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Dto.Dtos
{
    public class SearchRequestDto //: BaseDto
    {
        public string Origin { get; set; } = string.Empty;

        public string Destination { get; set; } = string.Empty;

        public DateTime DepartureDate { get; set; }
    }
}
