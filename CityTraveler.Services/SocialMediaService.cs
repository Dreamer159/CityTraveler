using CityTraveler.Infrastructure.Enums;
using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services
{
    public class SocialMediaService //: ISocialMedia
    {
        public IEnumerable<ITrip> TripReviews { get; set; }
        public IEnumerable<IEntertaiment> PlacesReviews { get ; set; }


        public IEnumerable<IEntertaiment> AddReview(Guid ent, IReview rev)
        {
            IEntertaiment updated = PlacesReviews.FirstOrDefault(x => x.Id == ent);
            updated.Reviews.Append(rev);
            PlacesReviews = PlacesReviews.Where(x=>x.Id != ent);
            return PlacesReviews.Append(updated);

        }

        public bool AddReview(Guid ent, IReview rev, ParameterType parameterType)
        {
            throw new NotImplementedException();
        }

        public bool AddReview(IReview rev)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITrip> AddReviewTrip(Guid trip, IReview rev)
         {
            ITrip updated = TripReviews.FirstOrDefault(x => x.Id == trip);
            //TripReviews = updated.Reviews.Append(rev);
            TripReviews = TripReviews.Where(x => x.Id != trip);
             return TripReviews.Append<ITrip>(updated);
         }

         public IEnumerable<IEntertaiment> GetReviews(IEntertaiment ent, IReview rev)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<ITrip> GetReviews(ITrip trip)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<IEntertaiment> GetReviewsOfUser(Guid id)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<ITrip> GetReviewsOfUserInTrip(Guid id)
         {
             throw new NotImplementedException();
         }

         public IEntertaiment GiveRating(Guid IdOwner, IRating rating, IEntertaiment ent)
         {
             throw new NotImplementedException();
         }

         public IEntertaiment GiveRating(Guid IdOwner, IRating rating, ITrip trip)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<IEntertaiment> RemoveReview(IEntertaiment ent, Guid IdReview)
         {
             throw new NotImplementedException();
         }

         public IEnumerable<ITrip> RemoveReview(ITrip trip, Guid IdReview)
         {
             throw new NotImplementedException();
         }
    }
}
