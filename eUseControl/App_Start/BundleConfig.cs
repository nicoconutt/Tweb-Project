using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace eUseControl.Web
    {
        public class BundleConfig
        {
            internal static void RegisterBundles(BundleCollection bundles)
            {
                bundles.Add(new StyleBundle("~/bundles/open-iconic-bootstrap/css").Include(
                    "~/Vendors/Css/open-iconic-bootstrap.min.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/animate/css").Include(
                    "~/Vendors/Css/animate.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/owl.carousel/css").Include(
                    "~/Vendors/Css/owl.carousel.min.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/owl.theme.default/css").Include(
                    "~/Vendors/Css/owl.theme.default.min.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/magnific-popup/css").Include(
                    "~/Vendors/Css/magnific-popup.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/aos/css").Include(
                    "~/Vendors/Css/aos.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/ionicons/css").Include(
                    "~/Vendors/Css/ionicons.min.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/bootstrap-datepicker/css").Include(
                    "~/Vendors/Css/bootstrap-datepicker.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/jquery.timepicker/css").Include(
                    "~/Vendors/Css/jquery.timepicker.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/flaticon/css").Include(
                    "~/Vendors/Css/flaticon.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/icomoon/css").Include(
                    "~/Vendors/Css/icomoon.css", new CssRewriteUrlTransform()));
                bundles.Add(new StyleBundle("~/bundles/style/css").Include(
                    "~/Vendors/Css/style.css", new CssRewriteUrlTransform()));



                bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include(
                    "~/Vendors/js/jquery.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery-migrate-3.0.1/js").Include(
                    "~/Vendors/js/jquery-migrate-3.0.1.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/popper/js").Include(
                    "~/Vendors/js/popper.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include(
                    "~/Vendors/js/bootstrap.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery.easing.1.3/js").Include(
                    "~/Vendors/js/jquery.easing.1.3.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery.waypoints/js").Include(
                    "~/Vendors/js/jquery.waypoints.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery.stellar/js").Include(
                    "~/Vendors/js/jquery.stellar.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/owl.carousel/js").Include(
                    "~/Vendors/js/owl.carousel.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/aos/js").Include(
                    "~/Vendors/js/aos.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery.magnific-popup/js").Include(
                    "~/Vendors/js/jquery.magnific-popup.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery.animateNumber/js").Include(
                    "~/Vendors/js/jquery.animateNumber.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker/js").Include(
                    "~/Vendors/js/bootstrap-datepicker.js"));
                bundles.Add(new ScriptBundle("~/bundles/jquery.timepicker/js").Include(
                    "~/Vendors/js/jquery.timepicker.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/scrollax/js").Include(
                    "~/Vendors/js/scrollax.min.js"));
                bundles.Add(new ScriptBundle("~/bundles/main/js").Include(
                    "~/Vendors/js/main.js"));


            }
        }
    }

