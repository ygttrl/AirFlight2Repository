using AirFlight2.Dto.Dtos;

namespace AirFlight2.Web.Services
{
    public class CountryApiService
    {
        private readonly HttpClient _httpClient;

        public CountryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CountryDto>> GetAllCountry() 
        {
            //https://localhost:7099/api/AirPort/GetAllAirPort
            var responce = await _httpClient.GetFromJsonAsync<ResponceDto<List<CountryDto>>>("https://localhost:7099/api/Country/GetAllCountry");

            return responce.Data;
        }

    }
}
