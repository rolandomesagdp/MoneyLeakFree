(function () {

    var ExpenseGroupCreateController = function ($scope, $location, expenseGroupService, errorHandler) {
        
        // Events:
        $scope.cancelCreate = function () {
            var url = "/configuration/expensegroups";
            $location.path(url);
        };

        var onCreateExpenseGroupSuccess = function (createdExpenseGroup) {
            var url = "/configuration/expensegroup/" + createdExpenseGroup.Id;
            $location.path(url);
        };

        var onCreateExpenseGroupError = function () {
            errorHandler.onHttpError($scope,
                                    "Expense Group",
                                    "ExpenseGroupCreateController",
                                    "expenseGroupService.createNewExpenseGroup()");
        };

        $scope.createExpenseGroup = function () {
            var expenseGroupToCreate = $scope.expenseGroupToCreate;
            expenseGroupService.createNewExpenseGroup(expenseGroupToCreate)
                                .then(onCreateExpenseGroupSuccess, onCreateExpenseGroupError);
        };
    };

    // Register Controller:
    var app = angular.module("moneyLeakFree");

    app.controller("ExpenseGroupCreateController", ["$scope", "$location", "expenseGroupService", "errorHandler", ExpenseGroupCreateController]);

}());