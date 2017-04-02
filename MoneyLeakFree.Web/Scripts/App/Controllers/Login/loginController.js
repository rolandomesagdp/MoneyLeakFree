(function () {

    var LoginController = function ($scope, accountService, currentUserService) {

        $scope.message = "";

        $scope.userIsLogedIn = false;

        $scope.userData = {
            userName: "",
            email: "",
            password: "",
            confirmPassword: "",
            grant_type: ""
        };

        var onUserLoginSuccess = function (data) {
            currentUserService.setProfile(data.userName, data.access_token);

            $scope.userIsLogedIn = currentUserService.getProfile().isLogedIn;
        };

        var onUserLoginError = function (data) {
            $scope.userIsLogedIn = false;
        };

        $scope.loginUser = function () {
            var userToLogin = $scope.userData;
            userToLogin.grant_type = "";
            userToLogin.userName = $scope.userData.email;

            userToLogin.grant_type += "username=" + encodeURIComponent(userToLogin.userName) +
                                        "&password=" + encodeURIComponent(userToLogin.password)
                                        + "&grant_type=password";





            accountService.loginUser(userToLogin)
                            .then(onUserLoginSuccess, onUserLoginError);
        };
        
        var onUserRegisterSuccess = function () {
            $scope.userIsLogedIn = true;
        };

        var onUserRegisterError = function () {
            $scope.userIsLogedIn = false;
            scope.message = "There was an error while registering the user";
        };

        $scope.registerUser = function () {
            var userToRegister = $scope.userData;
            userToRegister.confirmPassword = $scope.userData.password;

            accountService.registerUser(userToRegister)
                            .then(onUserRegisterSuccess, onUserRegisterError);
        };
    }

    // controller registration.
    var module = angular.module("moneyLeakFree");
    module.controller("LoginController", ["$scope", "accountService", "currentUserService", LoginController]);

}());