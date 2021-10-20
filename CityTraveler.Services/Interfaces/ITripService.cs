using CityTraveler.Domain.Entities;
using CityTraveler.Domain.Enums;
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

        public bool DeleteTrip(TripModel trip);

        public IEnumerable<TripModel> GetTrips(int skip = 0, int take = 10);

        public TripModel GetTripById(Guid tripId);

        //public IEnumerable<TripModel> GetTripByPlace(Guid placeId);

        public IEnumerable<TripModel> GetTripByPlace(Guid placeId, EntertainmentType type);

        public IEnumerable<TripModel> GetTripByDate(DateTime date);

        public IEnumerable<TripModel> GetTripsByAverageRating(double rating);

        public IEnumerable<TripModel> GetTripsByOptimalSpent(TimeSpan optSpent);
        public IEnumerable<TripModel> GetTripsByEntartainmentName(string name);

        public IEnumerable<TripImageModel> GetImagesFromtrip(Guid tripId);


        public IEnumerable<TripModel> GetTripsOrderedByRatingBy();
        public IEnumerable<TripModel> GetTripsOrderdByRatingByDesc();
    }
}
