using CityTraveler.Infrastructure.Enums;
using CityTraveler.Infrastructure.Interfaces;
using CityTraveler.Infrastructure.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    public class SocialMediaService : ISocialMedia
    {
        public IEnumerable<ITrip> Reviews { get; set; }
        public IEnumerable<IEntertaiment> ReviewsEn { get ; set; }


        public IEnumerable<IEntertaiment> AddReview(Guid ent, IReview rev)
        {
            IEntertaiment updated = ReviewsEn.FirstOrDefault(x => x.Id == ent);
            updated.Reviews.Append<IReview>(rev);
            ReviewsEn =  ReviewsEn.Where(x=>x.Id != ent);
            return ReviewsEn.Append<IEntertaiment>(updated);

        }

        public bool AddReview(Guid ent, IReview rev, ParameterType parameterType)
        {
            throw new NotImplementedException();
        }

        /* public IEnumerable<ITrip> AddReviewTrip(Guid trip, IReview rev)
         {
             ITrip updated = Reviews.FirstOrDefault(x => x.Id == trip);
             updated.Reviews.Append<IReview>(rev);
             ReviewsEn = ReviewsEn.Where(x => x.Id != trip);
             return ReviewsEn.Append<ITrip>(updated);
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
         }*/
    }
}
