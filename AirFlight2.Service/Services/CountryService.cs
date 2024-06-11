using AirFlight2.Core.Repositories;
using AirFlight2.Core.Services;
using AirFlight2.Core.UnitOfWork;
using AirFlight2.Dto.Dtos;
using AirFlight2.Entities.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Service.Services
{
    public class CountryService : Service<Country, CountryDto>, ICountryService
    {
        private readonly ICountryRepository _repository;
        private readonly IMapper _mapper;
        public CountryService(ICountryRepository repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
