using RestaurantReviews.Filters;
using RestaurantReviews.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReviews.Controllers
{
    public class ReviewsController : Controller
    {

        private RestaurantReviewDbRepo _repo = new RestaurantReviewDbRepo();

        [ChildActionOnly]
        public ActionResult BestReview ()
        {
            var bestReview = _repo.Reviews.OrderByDescending(r => r.Rating).First();
            return PartialView("_Review", bestReview);
        }

        // GET: Reviews
        public ActionResult Index([Bind(Prefix = "id")]int? restaurantId)
        {
            if (restaurantId.HasValue)
                return View(_repo.GetRestaurantReviews(restaurantId.Value));
            else
                return HttpNotFound();
        }
            

        // GET: Reviews/Details/5
        [CheckReviewId]
        public ActionResult Details(int id)
        {
            var review = _repo.GetReview(id);
            return View(review);
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        [CheckReviewId]
        public ActionResult Edit(int id)
        {
            var review = _repo.GetReview(id);
            return View(review);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        [CheckReviewId]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _repo.GetReview(id);
            if (TryUpdateModel(review))
                return RedirectToAction("Index");
            else
                return View(review);
        }

        // GET: Reviews/Delete/5
        [CheckReviewId]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        [CheckReviewId]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
