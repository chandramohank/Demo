(function () {
    var app = angular.module('EmployeeModule');
    app.controller("employeeDetail", ['$scope', '$location', '$routeParams', 'employeeService', employeeData]);

    function employeeData($scope, $location, $routeParams, employeeService) {

        var empId = $routeParams.id;
        var promise = employeeService.getEmployee(empId);
        promise.then(
            function (response) {
                $scope.employee = response;
            }
            , function (response) {
                alert('Failed: ' + response);
            }
         );
        $scope.updateEmployee = function () {
            var empId = $routeParams.id;
            $scope.employee._id = JSON.parse(String.format('{ "$oid":"{0}" }',empId));
            var data = angular.toJson($scope.employee);

           
            var promise = employeeService.updateEmployee(empId, data);
                //.success(function (data) {
            //    //service.albums = data;
            //    $location.path('/Home/EmplyeeDashBoard');
            //})
            //        .error(function () {
            //            alert('Failed: ' + response);
            //        });
            promise.then(
                function (response) {
                    $location.path('/EmplyeeDashBoard');
                }
                , function (response) {
                    alert('Failed: ' + response);
                }
             );
        }
        $scope.deleteEmployee = function () {
            var empId = $routeParams.id;
            //$scope.employee._id = JSON.parse(String.format('{ "$oid":"{0}" }', empId));
            //var data = angular.toJson($scope.employee);

           
            var promise = employeeService.deleteEmployee(empId);           
            promise.then(
                function (response) {
                    $location.path('/EmplyeeDashBoard');
                }
                , function (response) {
                    alert('Failed: ' + response);
                }
             );
        }
        $scope.cancel = function () {
            $location.path('/EmplyeeDashBoard');
            cancel.$inject = ['$location'];
        }
    }
}
());