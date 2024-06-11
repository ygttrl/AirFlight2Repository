using AirFlight2.Dto.Dtos;
using AirFlight2.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Core.Repositories
{
    public interface IAirPortRepository : IGenericRepository<AirPort>
    {
        Task<IQueryable<AirPort>> GetByCountryIdWithAirPort(int id);


        Task<AirPort> GetByAirPortbyIdWithCountry(int id);
    }
}
