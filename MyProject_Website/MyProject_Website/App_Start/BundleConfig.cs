using System.Web;
using System.Web.Optimization;

namespace MyProject_Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/*.css"));
        }
    }
}