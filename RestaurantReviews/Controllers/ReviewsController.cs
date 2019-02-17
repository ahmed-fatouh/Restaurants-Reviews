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

        private IRestaurantReviewRepo _repo = new RestaurantReviewRepo();

        [ChildActionOnly]
        public ActionResult BestReview ()
        {
            var bestReview = _repo.Reviews.OrderByDescending(r => r.Rating).First();
            return PartialView("_Review", bestReview);
        }

        // GET: Reviews
        public ActionResult Index()
        {
            return View(_repo.Reviews);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            var review = _repo.GetReview(id);
            if (review == null)
                return HttpNotFound();
            else
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
        public ActionResult Edit(int id)
        {
            var review = _repo.GetReview(id);
            if (review == null)
                return HttpNotFound();
            else
                return View(review);
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _repo.GetReview(id);
            if (TryUpdateModel(review))
                return RedirectToAction("Index");
            else
                return View(review);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
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
