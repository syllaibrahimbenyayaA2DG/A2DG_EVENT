using System.Web;
using System.Web.Optimization;

namespace A2DGEvent
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Template/css").Include(
                "~/Content/font-awesome.min.css",
                "~/Content/Template/bootstrap.min.css",
                "~/Content/Template/mdb.css"
                ));

            bundles.Add(new StyleBundle("~/Template/js").Include(
                "~/Scripts/Template/popper.min.js",
                "~/Scripts/Template/bootstrap.min.js",
                "~/Scripts/Template/mdb.min.js"
                ));
            bundles.IgnoreList.Clear(); //Tell the ASP.NET bundles to allow minified files in debug mode.
        }
    }
}
