(function () {

    var expenseGroupService = function ($http) {

        var methodsToExpose = function () {
            return {
                getExpenseGroups: getExpenseGroups,
                getExpenseGroupById: getExpenseGroupById,
                editExpenseGroup: editExpenseGroup,
                createNewExpenseGroup: createNewExpenseGroup,
                deleteExpenseGroup: deleteExpenseGroup
            };
        };

        // Service Methods:
        var getExpenseGroups = function () {
            return $http.get("/api/expensegroups")
                        .then(function (response) {
                            var expenseGroups = response.data;
                            return expenseGroups;
                        });
        };

        var getExpenseGroupById = function (expenseGroupId) {
            return $http.get("/api/expensegroup/" + expenseGroupId)
                        .then(function (response) {
                            var expenseGroup = response.data;
                            return expenseGroup;
                        });
        };

        var createNewExpenseGroup = function (expenseGroupToCreate) {
            return $http.post("api/expensegroup/create", expenseGroupToCreate)
                        .then(function (response) {
                            var createdExpenseGroup = response.data;
                            return createdExpenseGroup;
                        });
        };

        var editExpenseGroup = function (expenseGroupToEdit) {
            var url = "api/expensegroup/edit";
            return $http.put(url, expenseGroupToEdit)
                        .then(function (response) {
                            var expenseGropu = response.data
                            return expenseGropu;
                        });
        }

        var deleteExpenseGroup = function (expenseGroupId) {
            var url = "api/expensegroup/delete/" + expenseGroupId;
            return $http.delete(url)
                        .then(function (response) {
                            var deleteMessage = response.data;
                            return deleteMessage;
                        });
        }

        // Private Methods

        return methodsToExpose();
    };

    // Registering ExpenseService in Angular:
    var app = angular.module("commonServices");
    app.factory("expenseGroupService", ["$http", expenseGroupService]);

}());