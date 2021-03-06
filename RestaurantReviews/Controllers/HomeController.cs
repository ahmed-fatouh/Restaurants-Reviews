﻿using RestaurantReviews.Models;
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
            return RedirectToAction("Index", "Restaurant");
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