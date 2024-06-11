using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Entities.Models
{
    public class AirPort : BaseEntity
    {
        public string AirPortName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
