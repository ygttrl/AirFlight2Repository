using AirFlight2.Dto.Dtos;
using static System.Net.WebRequestMethods;

namespace AirFlight2.Web.Services
{
    public class SearchApiService
    {
        private readonly HttpClient _httpClient;

        public SearchApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<SearchResultDto> AvailabilitySearch(SearchRequestDto request) 
        {
            //https://localhost:7099/api/Search/AvailabilitySearchFlight?Origin=aaaa&Destination=aaaa&DepartureDate=2024-06-22
            //
            string link = string.Empty;
            link = "https://localhost:7099/api/Search/AvailabilitySearchFlight?Origin=";
            link += request.Origin;
            link += "&Destination=";
            link += request.Destination;
            link += "&DepartureDate=";
            link += request.DepartureDate.ToString("yyyy-MM-dd");
            var result = await _httpClient.GetFromJsonAsync<ResponceDto<SearchResultDto>>(link);

            return result.Data;
        }

    }
}
