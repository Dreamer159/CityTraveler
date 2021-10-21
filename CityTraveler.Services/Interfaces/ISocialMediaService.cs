using CityTraveler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface ISocialMediaService : IServiceMetadata
    {
        Task<ReviewModel> AddReviewEntertainment(Guid enterId, ReviewModel rev);
        Task<ReviewModel> AddReviewTrip(Guid tripId, ReviewModel rev);
        Task<bool> RemoveReview(Guid reviewId);
        IEnumerable<ReviewModel> GetReviews(int skip = 0, int take = 10);
        IEnumerable<ReviewModel> GetUserReviews(Guid userId);
        IEnumerable<ReviewModel> GetObjectReviews(Guid objectId);
        //TODO
        Task<ReviewModel> PostRating(RatingModel rating, Guid reviewId);
        Task<bool> AddComment(CommentModel comment, Guid reviewId);
        Task<bool> RemoveComment(Guid commentId, Guid reviewId);

    }
}
