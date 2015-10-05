
(function () {
    var app = angular.module("EmployeeModule");
    app.factory('employeeService', ['$http', '$q','appVariables',
        function employeeService($http, $q, appVariables) {
            // interface
            var service = {
                get: get,
                getEmployee: getEmployee,
                updateEmployee: updateEmployee,
                deleteEmployee:deleteEmployee
            };
            return service;

            // implementation
            function get() {
                var def = $q.defer();

                $http.get(String.format(appVariables.mongoApiUrl, appVariables.database, appVariables.EmpTable, appVariables.apiKey))
                    .success(function (data) {
                        //service.albums = data;
                        def.resolve(data);
                    })
                    .error(function () {
                        def.reject("Failed to get albums");
                    });
                return def.promise;
            }
            function getEmployee(empId) {
                var def = $q.defer();
                $http.get(String.format(appVariables.getEmployeeURL, appVariables.database, appVariables.EmpTable, empId,appVariables.apiKey ))
                    .success(function (data) {
                        //service.albums = data;
                        def.resolve(data);
                    })
                    .error(function () {
                        def.reject("Failed to get albums");
                    });
                return def.promise;
            }
            function updateEmployee(empId, postData) {
                var data = postData;
                
                var def = $q.defer();
                $http.put(String.format(appVariables.updateEmployeeURL, appVariables.database, appVariables.EmpTable, empId, appVariables.apiKey), data)
                    .success(function (data) {
                        //service.albums = data;
                        def.resolve(data);
                    })
                    .error(function (data) {
                        def.reject("Failed to get albums");
                    });

                return def.promise;
            }
            function deleteEmployee(empId) {
                
                var def = $q.defer();
                $http.delete(String.format(appVariables.deleteEmployeeURL, appVariables.database, appVariables.EmpTable, empId, appVariables.apiKey))
                    .success(function (data) {
                        //service.albums = data;
                        def.resolve(data);
                    })
                    .error(function (data) {
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