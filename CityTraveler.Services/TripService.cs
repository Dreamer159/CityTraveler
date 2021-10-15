using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityTraveler.Infrastructure.Interfaces;
using CityTraveler.Services.Interfaces;

namespace CityTraveler.Services
{
    public class TripService : ITripService

    {
        public bool IsActive { get; set; }
        public string Version { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public bool AddNewTrip(ITrip newTrip)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTrip(Guid tripId)
        {
            throw new NotImplementedException();
        }

        public ITrip GetTripById(Guid tripId)
        {
            throw new NotImplementedException();
        }

        public Dictionary<Guid, Guid> GetTripByLandscape(Guid landscapeId, Guid tripId)
        {
            throw new NotImplementedException();
        }

        public Dictionary<Guid, Guid> GetTripByRating(Guid ratingId, Guid tripId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITrip> GetTrips()
        {
            throw new NotImplementedException();
        }
    }
}
