using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Dto.Dtos
{
    public class AirPortDto : BaseDto
    {
        public string AirPortName { get; set; }
        public int CountryId { get; set; }
        public CountryDto Country { get; set; }
    }
}
