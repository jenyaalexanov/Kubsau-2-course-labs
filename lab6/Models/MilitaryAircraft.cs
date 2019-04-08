using lab6.Models.TransportType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.Models
{
    public class MilitaryAircraft : AircraftType
    {
        public List<ProducingCountries> ProducingCountries { get; set; }
    }
}
