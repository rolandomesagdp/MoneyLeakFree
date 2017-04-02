(function () {

    var currentUserService = function () {

        var profile = {
            isLogedIn: false,
            userName: "",
            token: ""
        };

        var setProfile = function (userName, token) {
            profile.isLogedIn = true;
            profile.userName = userName;
            profile.token = token;
        };

        var getProfile = function () {
            return profile;
        };

        var methodsToExpose = function() {

            return {
                setProfile: setProfile,
                getProfile: getProfile
            };
        };

        return methodsToExpose();

    };

    var app = angular.module("commonServices");
    app.factory("currentUserService", [currentUserService]);

}());


//(function () {

//    var currentUserService = function () {

//        var methodsToExpose = function () {
//            return {
//                loginUser: loginUser,
//                registerUser: registerUser
//            };
//        };

//        // Service Methods:
        

            

        

//        return methodsToExpose();
//    };

//    // Registering AccountService in Angular:
//    var app = angular.module("commonServices");
//    app.factory("currentUserService", [currentUserService]);

//}());