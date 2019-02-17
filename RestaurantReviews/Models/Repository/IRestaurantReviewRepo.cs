using System.Collections.Generic;

namespace RestaurantReviews.Models.Repository
{
    public interface IRestaurantReviewRepo
    {
        List<RestaurantReview> Reviews { get; }

        void AddReview(RestaurantReview review);
        void DeleteReview(int id);
        RestaurantReview GetReview(int id);
        void UpdateReview(RestaurantReview review);
    }
}