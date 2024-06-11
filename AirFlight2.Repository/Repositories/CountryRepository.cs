using AirFlight2.Core.Repositories;
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
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(AppDbContext context ) : base(context )
        {
        }
    }
}
