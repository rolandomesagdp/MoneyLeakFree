// App Module

(function () {
    var app = angular.module("moneyLeakFree", ["ngRoute"]);

    app.config(function ($routeProvider, $locationProvider) {

        $routeProvider.when("/home", {
            templateUrl: "Scripts/App/Views/homeIndex.html",
            controller: "HomeIndexController"
        }).
        when("/configuration/expensegroups", {
            templateUrl: "Scripts/App/Views/Configuration/expenseGroupsList.html",
            controller: "ExpenseGroupsListController"
        })
        .otherwise({ redirectTo: "/home" });

        //$locationProvider.html5Mode({
        //    enabled: true,
        //    requireBase: false
        //});
    });

}());