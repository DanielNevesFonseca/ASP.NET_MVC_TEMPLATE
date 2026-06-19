
using System.Web.Optimization;

namespace MyApplication
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/ui").Include(
                "~/Scripts/jquery-3.4.1.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/vue.min.js"
                )
            );

            bundles.Add(new StyleBundle("~/Styles/bootstrap").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/Site.css"
                ));
        }
    }
}

