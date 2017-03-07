
(function () {

    var ExpenseGroupEditController = function ($scope, $routeParams, $location, expenseGroupService, errorHandler) {

        var expenseGroupId = $routeParams.expenseGroupId;

        // On Load Methods
        var onExpenseGroupDetailsSuccess = function (expenseGroupDetails) {
            $scope.expenseGroupToEdit = expenseGroupDetails;
        };

        var onGetExpenseGroupByIdError = function () {
            errorHandler.onHttpError($scope,
                                    "Expense Group",
                                    "ExpenseGroupDetailsController",
                                    "expenseGroupService.getExpenseGroupById()");
        };

        expenseGroupService.getExpenseGroupById(expenseGroupId)
                            .then(onExpenseGroupDetailsSuccess, onGetExpenseGroupByIdError);


        // Privated Functions
        var onExpenseGroupEditSuccess = function (editedExpenseGroup) {
            var urlToRedirect = "/configuration/expensegroup/" + editedExpenseGroup.Id;
            $location.path(urlToRedirect);
        };

        var onExpenseGroupEditError = function () {
            errorHandler.onHttpError($scope,
                                    "Expense Group",
                                    "ExpenseGroupDetailsController",
                                    "expenseGroupService.editExpenseGroup()");
        };

        // Public Functions

        $scope.editExpenseGroup = function () {
            var expenseGroupToEdit = $scope.expenseGroupToEdit;
            expenseGroupService.editExpenseGroup(expenseGroupToEdit)
                                .then(onExpenseGroupEditSuccess, onExpenseGroupEditError);
        };

        $scope.cancelEdit = function () {
            var urlToRedirect = "/configuration/expensegroups";
            $location.path(urlToRedirect);
        };

    };

    // Register Controller
    var app = angular.module("moneyLeakFree");
    app.controller("ExpenseGroupEditController", ["$scope", "$routeParams", "$location", "expenseGroupService", "errorHandler", ExpenseGroupEditController]);

}());