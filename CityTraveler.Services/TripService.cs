using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityTraveler.Domain.Entities;
using CityTraveler.Domain.Enums;
using CityTraveler.Infrastucture.Data;
using CityTraveler.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CityTraveler.Services
{
    public class TripService : ITripService
    {
        private ApplicationContext _context;
        public TripService(ApplicationContext context)
        {
            _context = context;
        }

        public bool IsActive { get; set; }
        public string Version { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public bool AddNewTrip(TripModel newTrip)
        {
            _context.Trips.Add(newTrip);
            _context.SaveChanges();

            return true;
        }

        public bool DeleteTrip(TripModel trip)
        {
            _context.Trips.Remove(trip);
            _context.SaveChanges();

            return true;
        }

     

        public TripModel GetTripById(Guid tripId)         
        {
            var trip= _context.Trips.Where(x => x.Id == tripId);
            _context.SaveChanges();

            return (TripModel)trip;

        }

        public IEnumerable<TripModel> GetTripByPlace(Guid placeId, EntertainmentType type)
        {
            var trips = _context.Trips;


            return (IEnumerable<TripModel>)trips;
        }

        public IEnumerable<TripModel> GetTripByDate(DateTime date)
        {

            var trips = _context.Trips.Where(x => x.TripStart == date);
            _context.SaveChanges();

            
            return trips;
        }
        public IEnumerable<TripModel> GetTripsByAverageRating(double rating)
        {
            var trips = _context.Trips.Where(x => x.AverageRating == rating);
            _context.SaveChanges();

            return trips;
        }

        public IEnumerable<TripModel> GetTripsByOptimalSpent(TimeSpan optSpent)
        {

            var trips = _context.Trips.Where(x => x.OptimalSpent == optSpent);
            _context.SaveChanges();

            return trips;
        }

        public IEnumerable<TripModel> GetTripByPlace(EntertaimentModel entertaiment)
        {
            var trips = _context.Trips.Where(x => x.Entertaiment == entertaiment);
            return trips;
        }
        public IEnumerable<TripModel> GetTripsByEntartainmentName(string name)
        {
            var trips = _context.Trips.Where(x => x.Title == name);
            return trips;
        }



        public IEnumerable<TripImageModel> GetImagesFromtrip(Guid tripId)
        {
            return  _context.TripImages.Where(x => x.TripId == tripId);

        }

 
        public IEnumerable<TripModel> GetTrips(int skip = 0, int take = 10)
        {
            return _context.Trips.Skip(skip).Take(take);
        }


        public IEnumerable<TripModel> GetTripsOrderedByRatingBy()
        {
            var trips = _context.Trips.OrderBy(x => x.AverageRating);
            return trips;
        }

        public IEnumerable<TripModel> GetTripsOrderdByRatingByDesc()
        {
            return _context.Trips.OrderByDescending(x => x.AverageRating);
        }
    }
}
