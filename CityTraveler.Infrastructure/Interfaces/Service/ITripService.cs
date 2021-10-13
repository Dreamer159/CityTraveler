using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Infrastructure.Interfaces.Service
{
    interface ITripService:IServiceMetadata
    {
        public bool AddNewTrip(ITrip newTrip);

        public bool DeleteTrip(ITrip trip);

        public IEnumerable<ITrip> GetTrips(IEnumerable<Guid> guids);

        public ITrip GetTripById(Guid tripId);

        public Dictionary<Guid, Guid> GetTripByLandscap(Guid landscapeId, Guid tripId);

        public Dictionary<Guid, Guid> GetTripByRating(Guid ratingId, Guid tripId);



    }
}
