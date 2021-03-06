﻿using System.Web;
using System.Web.Optimization;

namespace MoneyLeakFree.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular.min.js",
                        "~/Scripts/angular-route.min.js",
                        "~/Scripts/App/Services/commonServices.js",
                        "~/Scripts/App/app.js",
                        "~/Scripts/App/Services/accountService.js",
                        "~/Scripts/App/Services/currentUserService.js",
                        "~/Scripts/App/Services/expenseGroupService.js",
                        "~/Scripts/App/Services/errorHandler.js",
                        "~/Scripts/App/Controllers/homeIndexController.js",
                        "~/Scripts/App/Controllers/Login/loginController.js",
                        "~/Scripts/App/Controllers/Configuration/expenseGroupsListController.js",
                        "~/Scripts/App/Controllers/Configuration/expenseGroupDetailsController.js",
                        "~/Scripts/App/Controllers/Configuration/expenseGroupEditController.js",
                        "~/Scripts/App/Controllers/Configuration/expenseGroupCreateController.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/template").Include(
                      "~/Scripts/Template/custom.js",
                      "~/Scripts/Template/ddlevelsmenu.js",
                      "~/Scripts/Template/easing.js",
                      "~/Scripts/Template/flexslider.js",
                      "~/Scripts/Template/html5shiv.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/template").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/Template/css/ddlevelsmenu-base.css",
                      "~/Content/Template/css/ddlevelsmenu-topbar.css",
                      "~/Content/Template/css/flexslider.css",
                      "~/Content/Template/css/prettyPhoto.css",
                      "~/Content/Template/css/blue.css",
                      "~/Content/Template/css/style.css"));
        }
    }
}
