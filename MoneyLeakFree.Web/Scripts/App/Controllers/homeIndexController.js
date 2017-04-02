// homeIndex Controller
(function () {

    var HomeIndexController = function ($scope) {

        $scope.message2 = "Hello As VM Index Controller";
        // Entities:
        
        // On Page Load Functions
        //$scope.message = "Hello World Angular JS!";
    }

    // controller registration.
    var module = angular.module("moneyLeakFree");
    module.controller("HomeIndexController", ["$scope", HomeIndexController]);
    
}());
