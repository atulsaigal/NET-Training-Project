using System.Web;
using System.Web.Optimization;

namespace DemoMvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
           
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Modernizr/modernizr-2.8.3"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Bootstrap/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jQuery").Include(
                      "~/Scripts/Jquery/jquery-3.4.1.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Bootstrap/bootstrap.css",
                      "~/Content/Site/Site.css"));

            bundles.Add(new ScriptBundle("~/bundles/Javascript").Include(
                      "~/Scripts/Js/CreateNewAccountjs.js"));

            bundles.Add(new StyleBundle("~/bundles/Content/Css").Include(
                      "~/Content/Css/CreateNewAccount.css"));

            bundles.Add(new ScriptBundle("~/bundles/userrecord").Include(
                     "~/Scripts/Js/UserRecords.js", "~/Scripts/Js/ManagerPager.js"));

            bundles.Add(new ScriptBundle("~/bundles/Chart").Include(
                     "~/Scripts/Js/chart.js",
                     "~/Scripts/Js/fusioncharts.charts.js",
                     "~/Scripts/Js/fusioncharts.js",
                     "~/Scripts/Themes/fusioncharts.theme.zune.js"));
        }
    }
}
