using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    public abstract class Location
    {
        public string Name { set; get; }
        public IEnumerable<double> Coordinates { set; get; }
        public string Description { set; get; }
        public IEnumerable<Comment> Feedback { set; get; }
        public Guid ID { set; get; }
    }
}