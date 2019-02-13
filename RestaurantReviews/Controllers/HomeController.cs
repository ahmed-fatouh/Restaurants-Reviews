using RestaurantReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReviews.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            AboutModel model = new AboutModel()
            {
                Name = "Restaurant Reviews",
                Location = "Toronto, CA"
            };

            return View(model);
        }
    }
}