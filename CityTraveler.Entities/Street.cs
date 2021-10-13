using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    class Street : IStreet
    {
        public IEnumerable<ICoordinates> Coordinates { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get ; set ; }
        public DateTime Modified { get ; set ; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
