(function () {

    var errorHandler = function () {
        
        var methodsToExpose = function () {
            return {
                onHttpError: onHttpError
            };
        };

        // Private methods

        var onHttpError = function (scope, requestedResourse, componentName, methodCousingExeption) {
            var consoleErrormessage = "There was an error while executing method " + methodCousingExeption + " in component " + componentName;

            var userErrorMessage = "An error occurred while trying to get the " + requestedResourse + ". Please, go back and try again later.";

            scope.errorMessage = userErrorMessage;
            scope.errorThrown = true;

            console.error(consoleErrormessage);

        };

        return methodsToExpose();
    };

    // Register Service:

    var app = angular.module("moneyLeakFree");
    app.factory("errorHandler", errorHandler);

}());