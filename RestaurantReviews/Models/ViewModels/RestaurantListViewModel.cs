using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantReviews.Models.ViewModels
{
    public class RestaurantListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        [Display(Name="Reviews Count")]
        public int ReviewsCount { get; set; }
        [Display(Name = "Rating")]
        public double? AverageRating { get; set; }
    }
}