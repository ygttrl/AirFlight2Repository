using AirFlight2.Core.Repositories;
using AirFlight2.Dto.Dtos;
using AirFlight2.Entities.Models;
using AirFlight2.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Repository.Repositories
{
    public class AirPortRepository : GenericRepository<AirPort>, IAirPortRepository
    {
        
        public AirPortRepository(AppDbContext context ) : base(context)
        {
        } 

        public async Task<IQueryable<AirPort>> GetByCountryIdWithAirPort(int id) 
        {

            var data =  (from airPort in _context.AirPorts
                        where airPort.CountryId == id
                        select new AirPort
                        {
                            Id = airPort.Id,
                            CountryId = airPort.CountryId,
                            AirPortName = airPort.AirPortName,
                        }).AsNoTracking();


            return data;

        }


        public async Task<AirPort> GetByAirPortbyIdWithCountry(int id)
        {

            var data =await (from airport in _context.AirPorts
                        join country in _context.Countries
                        on airport.CountryId equals country.Id
                        where airport.Id == id
                        select new AirPort
                        {
                            Id = airport.Id,
                            AirPortName= airport.AirPortName,
                            CountryId= airport.CountryId,
                            Country = country
                        }
                        ).FirstOrDefaultAsync();

            return data;
        }

    }
}
