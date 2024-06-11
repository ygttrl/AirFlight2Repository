﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Dto.Dtos
{
    public class CountryDto : BaseDto
    {
        public string Name { get; set; }
        public List<AirPortDto> AirPorts { get; set; } = new List<AirPortDto>();
    }
}
