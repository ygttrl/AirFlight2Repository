using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirFlight2.Entities.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; } 
        public ICollection<AirPort> AirPorts { get; set; } 

    }
}
