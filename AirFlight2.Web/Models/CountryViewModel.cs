using AirFlight2.Dto.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering; 

namespace AirFlight2.Web.Models
{
    public class CountryViewModel
    {
        public IEnumerable<SelectListItem> Countries { get; set; } 
         
        public int AirPortOriginId { get; set; }
        public int AirPortOriginDestinationId { get; set; }

        public DateTime DateDeparture { get; set; }

        public DateTime DateReturn { get; set; }
    }
}
