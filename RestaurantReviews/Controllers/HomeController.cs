using RestaurantReviews.Models;
using RestaurantReviews.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReviews.Controllers
{
    public class HomeController : Controller
    {
        RestaurantReviewsDb _db = new RestaurantReviewsDb();

        public ActionResult Index()
        {
            //var model = from r in _db.Restaurants
            //            orderby r.Reviews.Average(rev => rev.Rating) descending
            //            select new RestaurantListViewModel()
            //            {
            //                Id = r.Id,
            //                Name = r.Name,
            //                City = r.City,
            //                Country = r.Country,
            //                ReviewsCount = r.Reviews.Count,
            //                AverageRating = r.Reviews.Average(rev => rev.Rating)
            //            };

            var model = _db.Restaurants
                        .OrderByDescending(r => r.Reviews.Average(rev => rev.Rating))
                        .Select(r => new RestaurantListViewModel()
                        {
                            Id = r.Id,
                            Name = r.Name,
                            City = r.City,
                            Country = r.Country,
                            ReviewsCount = r.Reviews.Count,
                            AverageRating = r.Reviews.Average(rev => rev.Rating)
                        });

            return View(model);
        }

        public ActionResult About()
        {
            AboutModel model = new AboutModel()
            {
                Name = "Restaurant Reviews",
                Location = "Toronto, CA"
            };

            return View(model);
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}