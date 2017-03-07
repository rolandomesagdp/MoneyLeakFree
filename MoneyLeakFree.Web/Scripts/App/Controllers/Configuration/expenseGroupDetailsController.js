(function () {

    var ExpenseGroupDetailsController = function ($scope, $routeParams, expenseGroupService, errorHandler) {

        // On load functionalities:
        var expenseGroupId = $routeParams.expenseGroupId;

        var onExpenseGroupDetailsSuccess = function (expenseGroupDetails) {
            $scope.expenseGroupDetails = expenseGroupDetails;
        };

        var onGetExpenseGroupByIdError = function () {
            errorHandler.onHttpError($scope,
                                    "Expense Group",
                                    "ExpenseGroupDetailsController",
                                    "expenseGroupService.getExpenseGroupById()");
        };

        expenseGroupService.getExpenseGroupById(expenseGroupId)
                            .then(onExpenseGroupDetailsSuccess, onGetExpenseGroupByIdError);

    };

    // Registering Controller
    var app = angular.module("moneyLeakFree");
    app.controller("ExpenseGroupDetailsController", ["$scope", "$routeParams", "expenseGroupService", "errorHandler", ExpenseGroupDetailsController]);

}());