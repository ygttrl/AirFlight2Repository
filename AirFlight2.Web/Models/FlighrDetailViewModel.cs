using AirFlight2.Dto.Dtos;
 

namespace AirFlight2.Web.Models
{
    public class FlightDetailViewModel
    {
        public FlightDetailViewModel()
        {
            FlightOptions = new List<FlightOptionDto>();
        }
        public string AirPortOrigin { get; set; }
        public string  CountryOrigin { get; set; }
        public string AirPortDestination{ get; set; }
        public string CountryDestination { get; set; }

        public bool HasError { get; set; } 
        public List<FlightOptionDto> FlightOptions { get; set; }


    }
}
