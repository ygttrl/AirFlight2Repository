using AirFlight2.Dto.Dtos;
using AirFlight2.Entities.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<AirPort, AirPortDto>().ReverseMap();
            CreateMap<FlightReference.SearchResult,SearchResultDto>().ReverseMap();
            CreateMap<FlightReference.FlightOption,FlightOptionDto>().ReverseMap();
        }

    }
}
