using AirFlight2.Dto.Dtos;
using AirFlight2.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Core.Services
{
    public interface IAirPortService : IService<AirPort, AirPortDto>
    {
        public Task<ResponceDto<List<AirPortDto>>> GetByCountryIdWithAirPort(int id);
        public Task<ResponceDto<AirPortDto>> GetByAirPortbyIdWithCountry(int id);
    }
}
