
(function () {
    var app = angular.module("EmployeeModule");
    app.factory('employeeService', ['$http', '$q',
        function employeeService($http, $q) {
            // interface
            var service = {

                get: get
            };
            return service;

            // implementation
            function get() {
                var def = $q.defer();

                $http.get("http://localhost:64059/api/Employee/GetEmployees")
                    .success(function (data) {
                        //service.albums = data;
                        def.resolve(data);
                    })
                    .error(function () {
                        def.reject("Failed to get albums");
                    });
                return def.promise;
            }
        }]);
}());
//(function () {
//    var app = angular.module('EmployeeModule');
//    app.controller("EmployeeCtrl", getEmployeeData);

//    function getEmployeeData($scope, employeeService) {
//        var promise = employeeService.get();
//        promise.then(
//            function (response) {
//                $scope.employees = response;
//            }
//            , function (response) {
//                alert('Failed: ' + response);
//            }
//         );
//        getEmployeeData.$inject = ['$scope', 'employeeService'];
//    }
//}());