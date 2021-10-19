using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace CityTraveler.Domain.Entities
{
    public class ReviewModel : Entity, IDescribable
    {
        public virtual RatingModel Rating { get; set; }
        public virtual ApplicationUserModel User { get; set; }
        public virtual EventModel EventModel { get; set; }
        public virtual LandskapeModel LandskapeModel { get; set; }
        public virtual InstitutionModel InstitutionMode { get; set; }
        public virtual ICollection<ReviewImageModel> Images { get; set; } = new List<ReviewImageModel>();
        public virtual ICollection<CommentModel> Comments { get; set; } = new List<CommentModel>();
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
