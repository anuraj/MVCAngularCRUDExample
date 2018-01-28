using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Script/Bundles")
                .Include(
                    "~/bundles/inline.*",
                    "~/bundles/polyfills.*",
                    "~/bundles/scripts.*",
                    "~/bundles/vendor.*",
                    "~/bundles/main.*"));
            bundles.Add(new StyleBundle("~/Content/Styles")
                .Include("~/bundles/styles.*"));
        }
    }
}