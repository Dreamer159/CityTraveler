using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    public class City
    {
        public IEnumerable<Institution> Institution { get; set; }  
        public IEnumerable<Events> Events { get; set; }  
        public IEnumerable<Sightseeing> Sightseeing { get; set; } 
    }
}
