using System.Web;
using System.Web.Optimization;

namespace PINPRINT
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));


            //Bootstrap 4 (CSS)
            bundles.Add(new StyleBundle("~/css/bootstrap").Include(
                      "~/Content/css/bootstrap.css"));

            // Other CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/fontawesome.css",
                      "~/Content/css/style.css",
                      "~/Content/css/mdb.css",
                      "~/Content/css/main.css"));

            //Bootstrap 4 (JS)
            bundles.Add(new ScriptBundle("~/js/bootstrap").Include(
                      "~/Content/js/bootstrap.min.js"));

            // Other JS
            bundles.Add(new ScriptBundle("~/Content/js").Include(
                     "~/Content/js/jquery-3.4.1.min.js",
                     "~/Content/js/popper.min.js",
                     "~/Content/js/mdb.js"));
        }
    }
}
