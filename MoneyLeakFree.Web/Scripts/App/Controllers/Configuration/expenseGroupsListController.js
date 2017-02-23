(function () {

    var ExpenseGroupsListController = function ($scope) {

        $scope.pageName = function () {
            return "Expense Group List";
        };

    };

    // Registrer Controller
    var app = angular.module("moneyLeakFree");

    app.controller("ExpenseGroupsListController", ["$scope", ExpenseGroupsListController]);

}());