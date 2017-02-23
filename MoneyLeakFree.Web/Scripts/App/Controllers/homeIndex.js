// homeIndex Controller
(function () {

    var HomeIndexController = function ($scope, expensesService) {
        // Entities:

        var model = function () {
            var userId = "";
            var userName = "";
            var userLastName = "";

            return {
                Id: userId,
                Name: userName,
                LastName: userLastName
            };
        };

        $scope.model = model;

        // Functions
        var onGetUserSucess = function (response) {
            $scope.model.Id = response.data.Id;
            $scope.model.Name = response.data.Name;
            $scope.model.LastName = response.data.LastName;
        }

        var onGetUserError = function () {
            $scope.getUserErrorMessage = "User could not be fetched.";
        }

        // Op Page Load Functions
        $scope.message = "Hello World Angular JS!";

        expensesService.getExpenses()
             .then(onGetUserSucess, onGetUserError);
    }

    // controller registration.
    app.controller("HomeIndexController", ["$scope", "expensesService", HomeIndexController]);
    
}());
