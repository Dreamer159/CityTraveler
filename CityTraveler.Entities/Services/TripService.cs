using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CityTraveler.Infrastructure.Interfaces;
using CityTraveler.Infrastructure.Interfaces.Service;

namespace CityTraveler.Entities.Services
{
    public class TripService : ITripService

    {
        public bool IsActive { get; set ; }
        public string Version { get ; set; }
        public Guid Id { get ; set; }
        public DateTime Created { get ; set ; }
        public DateTime Modified { get; set; }
        public string Title { get; set ; }
        public string Description { get ; set; }


        public IEnumerable<ITrip> Trips { get; set; } = new List<ITrip>();
        public IEnumerable<ITrip> Template { get; set; } = new List<ITrip>();

        
        public bool AddNewTrip(ITrip trip)
        {
            Trips = Trips.Append(trip);
            return true;
        }

        public bool DeleteTrip(Guid tripId)
        {
            try
            {
                Trips = Trips.Where(x => x.Id != tripId);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }

        public IEnumerable<ITrip> GetTrips()
        {
            return Trips;
        }


        public ITrip GetTripById(Guid tripId)
        {
            return Trips.FirstOrDefault(x=>x.Id==tripId);
        }


        public bool UpdateTrip(ITrip trip)
        {
            try
            {

                Trips = Trips.Where(x => x.Id != trip.Id);
                Trips.Append(trip);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

      




        public Dictionary<Guid, Guid> GetTripByLandscap(Guid landscapeId, Guid tripId)
        {
            throw new NotImplementedException();
        }

        public Dictionary<Guid, Guid> GetTripByRating(Guid ratingId, Guid tripId)
        {
            throw new NotImplementedException();
        }

    
    }
}
