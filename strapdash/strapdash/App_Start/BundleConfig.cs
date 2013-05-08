using System.Web;
using System.Web.Optimization;

namespace bootstapDash
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery-1.9.1.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/knockout-2.2.1.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/style.css",
                "~/Content/css/bootstrap-responsive.min.css"));

            // The default behaviour is for the IgnoreList to ignore any minified scripts.
            // Clearing the IgnoreList will include our .min files.
            bundles.IgnoreList.Clear();
        }
    }
}