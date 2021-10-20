using CityTraveler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface ITripService : IServiceMetadata
    {
        public bool AddNewTrip(TripModel newTrip);

        public bool DeleteTrip(Guid tripId);

        public IEnumerable<TripModel> GetTrips(int skip = 0, int take = 10);

        public TripModel GetTripById(Guid tripId);

        public IEnumerable<TripModel> GetTripByPlace(Guid placeId);

        



    }
}
