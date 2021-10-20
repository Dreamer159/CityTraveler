using CityTraveler.Domain.Entities;
using CityTraveler.Infrastucture.Data;
using CityTraveler.Repository.DbContext;
using CityTraveler.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly ApplicationContext _dbContext;
        public SocialMediaService(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        /*private readonly IServiceContext _serviceContext;
        private readonly IDbContext _dbContext;
        public SocialMediaService(IServiceContext serviceContext, IDbContext dbContext)
        {
            _dbContext = dbContext;
            _serviceContext = serviceContext;
        }

        public async Task<IReview> AddReview(IReview rev)
        {
            _dbContext.Reviews.Collection.Add(rev);

            var query = $"";

            return await _dbContext.Reviews.RequestManager.ExecuteScalarAsync(query, null, false);
        }

        public async Task<IReview> AddReviewTrip(Guid tripId, IReview rev)
        {
            _dbContext.Reviews.Collection.Add(rev);

            var query = $"";

            return await _dbContext.Reviews.RequestManager.ExecuteScalarAsync(query, null, false);
        }

        public IEnumerable<IReview> GetObjectReviews(Guid objectId, PlaceType type)
        {
            switch (type)
            {
                case PlaceType.Event:
                    return _dbContext.Events.Collection.FirstOrDefault(x => x.Id == objectId).Reviews;
                case PlaceType.Institution:
                    return _dbContext.Institutions.Collection.FirstOrDefault(x => x.Id == objectId).Reviews;
                case PlaceType.Landscape:
                    return _dbContext.Landskapes.Collection.FirstOrDefault(x => x.Id == objectId).Reviews;
                default:
                    return Enumerable.Empty<IReview>();
            }
        }

        public IEnumerable<IReview> GetReviews(int skip = 0, int take = 10)
        {
            return _dbContext.Reviews.Collection.Skip(skip).Take(take);
        }

        public IEnumerable<IReview> GetTripReviews(Guid tripId)
        {
            return _dbContext.Trips.Collection.FirstOrDefault(x => x.Id == tripId).Reviews;
        }

        public IEnumerable<IReview> GetUserReviews(Guid userId)
        {
            return _dbContext.Reviews.Collection.Where(x => x.OwnerID == userId);
        }

        public async Task<IReview> PostRating(IRating rating, Guid reviewId)
        {
            _dbContext.Ratings.Collection.Add(rating);

            var review = _dbContext.Reviews.Collection.FirstOrDefault(x => x.Id == reviewId);
            review.Rating = rating;
            var query = $"";

            return await _dbContext.Reviews.RequestManager.ExecuteScalarAsync(query, null, false);
        }

        public async Task<bool> RemoveReview(Guid reviewId)
        {
            _dbContext.Reviews.Collection.RemoveAll(x => x.Id == reviewId);
            var query = $"";

            var affectedReviews = await _dbContext.Reviews.RequestManager.SendRequestAsync(query, null, false);
            return affectedReviews > 0;
        }*/
        public async Task<ReviewModel> AddReviewEntertainment(Guid enterId, ReviewModel rev)
        {
            try
            {
                EntertaimentModel en = _dbContext.Entertaiments.FirstOrDefault(x => x.Id == enterId);
                DbSet<EntertaimentModel> entertaimentModels = (DbSet<EntertaimentModel>)_dbContext.Entertaiments.Where(x => x.Id != enterId);
                en.Reviews.Add(rev);
                _dbContext.Entertaiments.Add(en);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e) 
            {
                return rev;
            }
            return rev;
        }

        public async Task<ReviewModel> AddReviewTrip(Guid tripId, ReviewModel rev)
        {
            //trip doesn`t have reviews in current version

            /*try
            {
                TripModel en = _dbContext.Trips.FirstOrDefault(x => x.Id == tripId);
                DbSet<EntertaimentModel> entertaimentModels = (DbSet<EntertaimentModel>)_dbContext.Entertaiments.Where(x => x.Id != tripId);
                en.Add(rev);
                _dbContext.Entertaiments.Add(en);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return rev;
            }*/
            return rev;
        }

        public IEnumerable<ReviewModel> GetObjectReviews(Guid objectId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewModel> GetReviews(int skip = 0, int take = 10)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewModel> GetTripReviews(Guid tripId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewModel> GetUserReviews(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<ReviewModel> PostRating(RatingModel rating, Guid reviewId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveReview(Guid reviewId)
        {
            throw new NotImplementedException();
        }
    }
}
