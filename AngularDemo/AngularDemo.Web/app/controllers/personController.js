(function () {
    var app = angular.module('EmployeeModule');
    app.controller("personCtrl", personController);
    personController.$inject = ['$scope', 'personService'];
    function personController($scope, personService) {
        var promise = personService.get();
        promise.then(
            function (response) {
                $scope.persons = response;
            }
            , function (response) {
                alert('Failed: ' + response);
            }
         );        
    }
})();