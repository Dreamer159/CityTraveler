using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    public class Sightseeing : Location
    {
        // Name, Coordinates, Description, Feedback, ID from abstract class Location
        public string History { set; get; }
    }
}