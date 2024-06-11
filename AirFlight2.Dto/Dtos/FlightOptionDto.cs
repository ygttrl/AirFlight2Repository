using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Dto.Dtos
{
    public class FlightOptionDto : BaseDto
    {

        public string FlightNumber { get; set; } = string.Empty;

        public DateTime DepartureDateTime { get; set; } = DateTime.Now;

        public DateTime ArrivalDateTime { get; set; } = DateTime.Now.AddDays(2);

        public decimal Price { get; set; }
    }
}
