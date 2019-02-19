using RestaurantReviews.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace RestaurantReviews.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<RestaurantReviewsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RestaurantReviewsDb context)
        {
            Restaurant[] restaurants = new Restaurant[]
            {
                new Restaurant { Name = "Cinnamon Club", Country = "UK", City = "London"},
                new Restaurant { Name = "Marrakesh", Country = "USA", City = "D.C."},
                new Restaurant { Name = "The House of Eliot", Country = "Ghent", City = "Belgium",
                                 Reviews = new RestaurantReview[] {
                                    new RestaurantReview { Body = "Wonderful Service",Rating = 10 } } }
            };
            context.Restaurants.AddOrUpdate( r => r.Name ,restaurants);
        }
    }
}
