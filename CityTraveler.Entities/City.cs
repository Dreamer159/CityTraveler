using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    public class City
    {
        public IEnumerable<string> Institution { get; set; } // change IEnumerable 
        public IEnumerable<string> Events { get; set; } // change IEnumerable 
        public IEnumerable<string> SightSeengs { get; set; } // change IEnumerable 
    }
}
