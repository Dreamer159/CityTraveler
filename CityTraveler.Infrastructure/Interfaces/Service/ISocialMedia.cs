using CityTraveler.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Infrastructure.Interfaces.Service
{
    public interface ISocialMedia {
        //no replies in our service
        // IEnumerable<ITrip> Reviews { get; set; } //comments, likes,images //TripService.Trips
        //  IEnumerable<IEntertaiment> ReviewsEn { get; set; }
        bool AddReview(Guid ent, IReview rev, ParameterType parameterType);

       /* ITrip AddReviewTrip(Guid trip, IReview rev);
        IEnumerable<IEntertaiment> RemoveReview(IEntertaiment ent, Guid IdReview);
        IEnumerable<ITrip> RemoveReview(ITrip trip, Guid IdReview);
        IEnumerable<IEntertaiment> GetReviews(IEntertaiment ent);
        IEnumerable<ITrip> GetReviews(ITrip trip);
        IEntertaiment GiveRating(Guid IdOwner, IRating rating, IEntertaiment ent);
        IEntertaiment GiveRating(Guid IdOwner, IRating rating, ITrip trip);
        IEnumerable<IEntertaiment> GetReviewsOfUser(Guid id);
        IEnumerable<ITrip> GetReviewsOfUserInTrip(Guid id);
*/

    }
}
