using AirFlight2.Dto.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Core.Services
{
    public interface ISearchService
    {
        Task<ResponceDto<SearchResultDto>> GetAvailabilitySearch(SearchRequestDto request);
    }
}
