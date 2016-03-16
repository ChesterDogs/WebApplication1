// Write your Javascript code.


// in support of the $scope topic in tutorial
// http://docs.asp.net/en/latest/client-side/angular.html
//
var personApp = angular.module('myAngularApp', []);
personApp.controller('personController', ['$scope', function ($scope) {
    $scope.jsName = 'Mary Jane';
}]);
//


// in support of the Modules topic in tutorial
// http://docs.asp.net/en/latest/client-side/angular.html
// module
var personApp = angular.module('myAngularApp', []);

// controller
personApp.controller('personController', function ($scope) {
    $scope.jsFirstName = "Mary";
    $scope.jsLastName = "Jane"
});