using RestaurantReviews.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RestaurantReviews.Filters
{
    //This checks if the supplied review id is valid, and if it corresponds to an existing review
    public class CheckReviewIdAttribute : ActionFilterAttribute
    {
        private IRestaurantReviewRepo _repo = new RestaurantReviewRepo();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int? id = filterContext.ActionParameters["id"] as int?;
            if (id == null)
            {
                filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.BadRequest,
                                                            "Id must be of numeric value");
                return;
            } 

            var review = _repo.GetReview(id.Value);
            if (review == null)
                filterContext.Result = new HttpNotFoundResult($"No review with Id: {id} found");
        }   
    }
}