using System.Web.Optimization;

namespace PairingTest.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
             "~/Scripts/jquery-3.1.1.js",
             "~/Scripts/jquery.jqURL.js",
             "~/Scripts/bootstrap.js",
             "~/Scripts/angular.js",
             "~/Scripts/angular-route.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/MyScripts").Include(
                  "~/App_Scripts/QuestionnaireConfig.js",
                  "~/App_Scripts/QuestionnaireCtrl.js"
                  ));

            bundles.Add(new StyleBundle("~/Bundles/Styles").Include(
               "~/Content/bootstrap.css",
              "~/Content/bootstrap-theme.css",
              "~/Content/bootstrap.min.css"
          ));

        }
    }
}