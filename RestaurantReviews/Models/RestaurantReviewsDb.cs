using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantReviews.Models
{
    public class RestaurantReviewsDb : DbContext
    {
        public RestaurantReviewsDb() : base("RestaurantReviewsContext")
        { }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantReview> Reviews { get; set; }
    }
}