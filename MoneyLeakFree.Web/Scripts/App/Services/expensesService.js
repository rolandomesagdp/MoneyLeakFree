(function () {

    var expensesService = function ($http) {

        // Service Methods:
        var getExpenses = function () {
            return $http.get("/api/person/568822D5-3D5C-45CB-8833-0DCAC4782D8C");
        };

        var addNewExpense = function () {
            // Do Something
        };

        return {
            getExpenses: getExpenses,
            addNewExpense: addNewExpense
        };
    };

    // Registering ExpenseService in Angular:
    var module = angular.module("moneyLeakFree");
    module.factory("expensesService", ["$http", expensesService]);

}());