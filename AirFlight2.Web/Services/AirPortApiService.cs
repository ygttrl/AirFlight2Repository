using AirFlight2.Dto.Dtos;

namespace AirFlight2.Web.Services
{
    public class AirPortApiService
    {

        private readonly HttpClient _httpClient;


        public AirPortApiService(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }

        public async Task<List<AirPortDto>> GetAirPortsWithCountryId(int id) 
        { 

            var responce = await _httpClient.GetFromJsonAsync<ResponceDto<List<AirPortDto>>>($"https://localhost:7099/api/AirPort/GetByCountryIdWithAirPort/{id}"); 

            return responce.Data;

        }
        
        public async Task<AirPortDto> GetAirPortbyId(int id) 
        { 

            var responce = await _httpClient.GetFromJsonAsync<ResponceDto<AirPortDto>>($"https://localhost:7099/api/AirPort/GetAirPortbyId/{id}"); 

            return responce.Data;

        }

        public async Task<AirPortDto> GetByAirPortbyIdWithCountry(int id) 
        {
            var responce = await _httpClient.GetFromJsonAsync<ResponceDto<AirPortDto>>($"https://localhost:7099/api/AirPort/GetByAirPortbyIdWithCountry/{id}");
            return responce.Data;
        }


    }
}
