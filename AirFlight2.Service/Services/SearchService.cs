using AirFlight2.Core.Services;
using AirFlight2.Dto.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Service.Services
{
    public class SearchService : ISearchService
    {
        private readonly IMapper _mapper;
        public SearchService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ResponceDto<SearchResultDto>> GetAvailabilitySearch(SearchRequestDto request)
        {

            var client = new FlightReference.AirSearchClient(FlightReference.AirSearchClient.EndpointConfiguration.BasicHttpBinding_IAirSearch);


            var srcResult = new FlightReference.SearchRequest
            {
                Origin = request.Origin,
                Destination = request.Destination,  
                DepartureDate   = request.DepartureDate
            };


            try
            {
                var result = await client.AvailabilitySearchAsync(srcResult);

                var flightOptionsDto = _mapper.Map<SearchResultDto>(result);

                return ResponceDto<SearchResultDto>.Success(200, flightOptionsDto);
            }
            catch (Exception ex )
            {

                return ResponceDto<SearchResultDto>.Fail(StatusCodes.Status500InternalServerError, ex.Message);
            } 
            
        }
    }


    
}
