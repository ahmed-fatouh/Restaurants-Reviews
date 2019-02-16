using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReviews.Controllers
{
    public class TestController : Controller
    {
        public ActionResult RouteValues()
        {
            return View(RouteData.Values);
        }

        public ActionResult QueryStringValues()
        {
            return View(Request.QueryString);
        }
    }
}