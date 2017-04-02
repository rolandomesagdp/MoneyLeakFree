// App Module

(function () {
    var app = angular.module("moneyLeakFree", ["ngRoute", "commonServices"]);

    app.config(function ($routeProvider, $locationProvider) {
        
        $routeProvider.when("/home", {
            templateUrl: "Scripts/App/Views/homeIndex.html",
            controller: "HomeIndexController"
        }).
        when("/configuration/expensegroups", {
            templateUrl: "Scripts/App/Views/Configuration/expenseGroupList.html",
            controller: "ExpenseGroupsListController"
        }).
        when("/configuration/expensegroup/:expenseGroupId", {
            templateUrl: "Scripts/App/Views/Configuration/expenseGroupDetails.html",
            controller: "ExpenseGroupDetailsController"
        }).
        when("/configuration/expensegroup/edit/:expenseGroupId", {
            templateUrl: "Scripts/App/Views/Configuration/expenseGroupEdit.html",
            controller: "ExpenseGroupEditController"
        }).
        when("/configuration/expensegroup", {
            templateUrl: "Scripts/App/Views/Configuration/expenseGroupCreate.html",
            controller: "ExpenseGroupCreateController"
        })
        .otherwise({ redirectTo: "/home" });

        //$locationProvider.html5Mode({
        //    enabled: true,
        //    requireBase: false
        //});
    });

}());