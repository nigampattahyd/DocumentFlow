using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace DocumentFlow.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                             "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/customJs").Include(
                "~/Content/js/bootstrap.min.js",
                "~/Content/plugins/jQuery/jquery-2.2.3.min.js",
                "~/Content/plugins/fastclick/fastclick.js",
                "~/Content/dist/js/app.min.js",
                "~/Content/plugins/sparkline/jquery.sparkline.min.js",
                "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                "~/Content/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                "~/Content/plugins/slimScroll/jquery.slimscroll.min.js",
                "~/Content/plugins/chartjs/Chart.min.js",
                "~/Content/dist/js/pages/dashboard2.js",
                "~/Content/dist/js/demo.js",
                "~/Scripts/jquery-ui-1.10.3.min.js",
                "~/Content/plugins/datepicker/bootstrap-datepicker.js",
                "~/Scripts/bootstrap-filestyle.min.js",
                "~/Content/plugins/input-mask/jquery.inputmask.js",
                "~/Content/plugins/input-mask/jquery.inputmask.numeric.extensions.js",
                "~/Scripts/FooTable/footable.js",
                "~/Content/plugins/input-mask/jquery.inputmask.phone.extensions.js",
     
                "~/Scripts/FooTable/handlebars-v2.0.0.js",
                "~/Scripts/FooTable/footable.filter.js",
                "~/Scripts/FooTable/footable.grid.js",
                "~/Scripts/FooTable/footable.paginate.js",
                "~/Scripts/FooTable/footable.sort.js",
                "~/Content/plugins/iCheck/icheck.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/css/bootstrap-slider/slider.css"));
            bundles.Add(new StyleBundle("~/Content/css/Customcss").Include(
                      "~/Content/css/font-awesome/ionicons.min.css",
                      
                      "~/Content/css/font-awesome/font-awesome.min.css",
                      "~/Content/dist/css/AdminLTE.css",
                      "~/Content/dist/css/skins/_all-skins.min.css",
                      "~/Content/plugins/iCheck/flat/blue.css",
                      "~/Content/plugins/morris/morris.css",
                      "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.css",
                      "~/Content/plugins/datepicker/datepicker3.css",
                      "~/Content/plugins/daterangepicker/daterangepicker.css",
                      "~/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                      "~/Content/FooTable/footable.core.css",
                      "~/Content/FooTable/footable.standalone.css"));


        }
    }
}