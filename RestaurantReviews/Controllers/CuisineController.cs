using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReviews.Controllers
{
    public class CuisineController : Controller
    {

        [ActionName("All")]
        public ActionResult Index(string name)
        {
            return Content("<<< Index|All action -> lists all cuisines >>>");
        }

        public ActionResult Details(string name)
        {
            return Json(new { Name = name, Action = "Details" }, JsonRequestBehavior.AllowGet);
        }

    }
}