using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface ITripService : IServiceMetadata
    {
        public bool AddNewTrip(ITrip newTrip);

        public bool DeleteTrip(Guid tripId);

        public IEnumerable<ITrip> GetTrips();

        public ITrip GetTripById(Guid tripId);

        public Dictionary<Guid, Guid> GetTripByLandscape(Guid landscapeId, Guid tripId);

        public Dictionary<Guid, Guid> GetTripByRating(Guid ratingId, Guid tripId);



    }
}
