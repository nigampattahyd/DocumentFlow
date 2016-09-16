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
            ScriptBundle Scripts = new ScriptBundle("~/Scripts/");
            Scripts.Include("~/Scripts/jquery-{version}.js",
                                "~/Scripts/bootstrap.min.js");
            Scripts.IncludeDirectory("~/Content/plugins/", "*.js", true);
            Scripts.IncludeDirectory("~/Content/dist/", "*.js", true);
            bundles.Add(Scripts);
            BundleTable.EnableOptimizations = true;

            StyleBundle Styles = new StyleBundle("~/Content/");
            Styles.IncludeDirectory("~/Content/css/", "*.css", true);
            Styles.IncludeDirectory("~/Content/plugins/", "*.css", true);
        }
    }
}