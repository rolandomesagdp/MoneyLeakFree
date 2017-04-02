(function () {

    var accountService = function ($http) {

        var methodsToExpose = function () {
            return {
                loginUser: loginUser,
                registerUser: registerUser
            };
        };

        // Service Methods:
        var loginUser = function (userToLogin) {
            var configuration = {
                headers: {
                    "Content-Type": "application/x-www-form-urlencoded"
                }
            };

            return $http.post("/token", userToLogin.grant_type, configuration)
                           .then(function (response) {
                               var responseData = response.data;

                               return responseData;
                           }, function (data) {
                               var errorResponse = data;

                               return data;
                           });
        };

        var registerUser = function (userToRegister) {
            return $http.post("api/Account/Register", userToRegister)
                        .then(function (response) {
                            var createdExpenseGroup = response.data;
                            return createdExpenseGroup;
                        });
        };

        return methodsToExpose();
    };

    // Registering AccountService in Angular:
    var app = angular.module("commonServices");
    app.factory("accountService", ["$http", accountService]);

}());