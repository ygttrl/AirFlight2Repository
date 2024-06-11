using AirFlight2.Core.Repositories;
using AirFlight2.Core.Services;
using AirFlight2.Core.UnitOfWork;
using AirFlight2.Dto.Dtos;
using AirFlight2.Entities.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Service.Services
{
    public class AirPortService : Service<AirPort, AirPortDto>, IAirPortService
    {
        private readonly IAirPortRepository _repository;
        private readonly IMapper _mapper;
        public AirPortService(IAirPortRepository  repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
            _repository = repository;
            _mapper = mapper; 
        }
        public  async Task<ResponceDto<List<AirPortDto>>>  GetByCountryIdWithAirPort(int id)
        {
            var airPorts =await _repository.GetByCountryIdWithAirPort(id).Result.ToListAsync();
            var airPortsDto = _mapper.Map<List<AirPortDto>>(airPorts);
            return ResponceDto<List<AirPortDto>>.Success(StatusCodes.Status200OK, airPortsDto); 
        }
        
        public async Task<ResponceDto<AirPortDto>> GetByAirPortbyIdWithCountry(int id)
        {
            var airPort = await _repository.GetByAirPortbyIdWithCountry(id);
            var airPortDto = _mapper.Map<AirPortDto>(airPort);
            return ResponceDto<AirPortDto>.Success(StatusCodes.Status200OK, airPortDto);
        }


    }
}
