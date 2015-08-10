//(function () {
//    angular.module("EmployeeModule", [])
//.controller("EmployeeCtrl", getEmployeeData);

//    function getEmployeeData($scope, $http) {
//        $http.get('http://localhost:64059/api/Employee/GetEmployees').
//        then(function (response) {
//            // this callback will be called asynchronously
//            // when the response is available
//            $scope.employees = response.data;

//        }, function (response) {
//            // called asynchronously if an error occurs
//            // or server returns response with an error status.
//        });
//        getEmployeeData.$inject = ['$scope', '$http'];
//    };
//}
//());
(function () {
    var app = angular.module('EmployeeModule');
    app.controller("EmployeeCtrl", getEmployeeData);

    function getEmployeeData($scope, employeeService) {
        var promise = employeeService.get();
        promise.then(
            function (response) {
                $scope.employees = response;
            }
            , function (response) {
                alert('Failed: ' + response);
            }
         );
        getEmployeeData.$inject = ['$scope', 'employeeService'];
    }
}
());