(function () {

    var ExpenseGroupsListController = function ($scope, $location, $route, expenseGroupService, errorHandler) {

        // On Load Methods

        var onGetExpenseGroupsSuccess = function (expenseGroups) {
            $scope.expenseGroupsList = expenseGroups;
        };

        var onGetExpenseGroupsError = function(){
            errorHandler.onHttpError($scope,
                                    "Expense Group List",
                                    "ExpenseGroupListController",
                                    "expenseGroupService.getExpenseGroups()");
        };

        var onExpenseGroupDeleteSuccess = function () {

            $route.reload();
        };

        var onDeleteExpenseGroupError = function () {
            errorHandler.onHttpError($scope,
                                    "Expense Group List",
                                    "ExpenseGroupListController",
                                    "expenseGroupService.deleteExpenseGroup()");
        };

        expenseGroupService.getExpenseGroups()
                           .then(onGetExpenseGroupsSuccess, onGetExpenseGroupsError);

        // Events Methods:

        $scope.expenseGroupDetails = function (expenseGroupId) {
            $location.path("/configuration/expensegroup/" + expenseGroupId);
        }

        $scope.editExpenseGroup = function (expenseGroupId) {
            var url = "/configuration/expensegroup/edit/" + expenseGroupId;
            $location.path(url);
        };

        $scope.createNewExpenseGroup = function () {
            var url = "/configuration/expensegroup";
            $location.path(url);
        };

        $scope.deleteExpenseGroup = function (expenseGroupId) {
            expenseGroupService.deleteExpenseGroup(expenseGroupId)
                                .then(onExpenseGroupDeleteSuccess, onDeleteExpenseGroupError);
        }
    };

    // Registrer Controller
    var app = angular.module("moneyLeakFree");

    app.controller("ExpenseGroupsListController", ["$scope", "$location", "$route", "expenseGroupService", "errorHandler", ExpenseGroupsListController]);

}());