using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace RestaurantReviews
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
                .Include("~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/ajax")
                .Include("~/Scripts/jquery.unobtrusive-ajax*"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/bootstrap*",
                         "~/Content/Site.css"));
        }
    }
}