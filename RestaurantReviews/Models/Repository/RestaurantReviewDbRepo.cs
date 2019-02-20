using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantReviews.Models.Repository
{
    public class RestaurantReviewDbRepo : IRestaurantReviewRepo
    {
        private RestaurantReviewsDb db = new RestaurantReviewsDb();

        public List<RestaurantReview> Reviews => db.Reviews.ToList();

        public RestaurantReview GetReview(int id) => db.Reviews.Find(id);

        public List<RestaurantReview> GetRestaurantReviews(int restaurantId) =>
            db.Reviews.Where(r => r.RestaurantId == restaurantId).ToList();

        public void AddReview(RestaurantReview review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
        }

        public void UpdateReview(RestaurantReview review)
        {
            RestaurantReview reviewToUpdate = GetReview(review.Id);
            if (reviewToUpdate == null)
                throw new Exception("Review not found");
            reviewToUpdate.Name = review.Name;
            reviewToUpdate.Body = review.Body;
            reviewToUpdate.Rating = review.Rating;
            db.SaveChanges();
        }

        public void DeleteReview(int id)
        {
            db.Reviews.Remove(new RestaurantReview { Id = id });
            db.SaveChanges();
        }
    }
}