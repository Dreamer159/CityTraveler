using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    public class Route : IRoute
    {
        public IEnumerable<ICoordinates> Coordinates { get; set ; }
        public TimeSpan OptimalSpent { get ; set ; }
        public TimeSpan RealSpent { get ; set ; }
        public IEnumerable<IPrice> Prices { get; set ; }
        public Guid Id { get ; set; }
        public DateTime Created { get ; set ; }
        public DateTime Modified { get; set; }
    }
}
