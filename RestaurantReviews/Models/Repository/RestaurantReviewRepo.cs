using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantReviews.Models.Repository
{
    public class RestaurantReviewRepo : IRestaurantReviewRepo
    {
        private static List<RestaurantReview> _reviews = new List<RestaurantReview>
        {
            new RestaurantReview
            {
                Id = 1,
                //Name = "Cinnamon Club",
                //Country = "UK",
                //City = "London",
                Rating = 10
            },
            new RestaurantReview
            {
                Id = 2,
                //Name = "Marrakesh",
                //Country = "D.C.",
                //City = "USA",
                Rating = 10
            },
            new RestaurantReview
            {
                Id = 3,
                //Name = "The House of Eliot",
                //Country = "Ghent",
                //City = "Belgium",
                Rating = 10
            }
        };

        public List<RestaurantReview> Reviews => _reviews;

        public RestaurantReview GetReview(int id) => _reviews.Find(r => r.Id == id);

        public void AddReview(RestaurantReview review) => _reviews.Add(review);

        public void UpdateReview(RestaurantReview review)
        {
            _reviews.RemoveAt(review.Id);
            _reviews.Add(review);
        }

        public void DeleteReview(int id) => _reviews.RemoveAt(id);
    }
}