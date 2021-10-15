using CityTraveler.Infrastructure.Enums;
using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface ISocialMediaService 
    {
        Task<IReview> AddReview(IReview rev);
        Task<IReview> AddReviewTrip(Guid tripId, IReview rev);
        Task<bool> RemoveReview(Guid reviewId);
        IEnumerable<IEntertaiment> GetReviews();
        IEnumerable<IReview> GetUserReviews(Guid userId);
        IEnumerable<IReview> GetTripReviews(ITrip tripId);
        IEnumerable<IReview> GetObjectReviews(Guid objectId);
        IReview PostRating(IRating rating, Guid reviewId);
    }
}
