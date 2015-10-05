(function () {
    var app = angular.module('EmployeeModule', ['ngRoute'])
    app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
        //debugger;
        //$routeProvider
        //    .when('/', { templateUrl: '/Home/index.cshtml', controller: 'EmployeeCtrl' })
        //    .when('/EmplyeeDashBoard',
        //    {
              
        //        templateUrl: '/Shared/EmplyeeDashBoard.cshtml', controller: 'EmployeeCtrl'
        //    })
        //    .when('/addEmployee', { templateUrl: '/Shared/addEmployee.cshtml', controller: 'EmployeeCtrl' });
        //$routeProvider
        //   .when('/', { templateUrl: '/home/index', controller: 'EmployeeCtrl' })
        //   .when('/EmplyeeDashBoard', { templateUrl: '/Views/Html/EmplyeeDashBoard.html', controller: 'EmployeeCtrl' })
        //   .when('/addEmployee', { templateUrl: '/Html/addEmployee.html', controller: 'EmployeeCtrl' });
        //$locationProvider.html5Mode({
        //    enabled: true
        //});

        // Specify the three simple routes ('/', '/About', and '/Contact')
        //$routeProvider.when('/', {
        //    templateUrl: '/Home/Index',
        //    controller: 'EmployeeCtrl',
        //});
        $routeProvider.when('/EmplyeeDashBoard', {
            templateUrl: '/Home/EmplyeeDashBoard',
            controller: 'EmployeeCtrl',
        });
        $routeProvider.when('/addEmployee', {
            templateUrl: '/Home/addEmployee',
            controller: 'EmployeeCtrl'
        });
        $routeProvider.when('/employee/:id', {
            templateUrl: '/Home/editEmployee',
            controller: 'employeeDetail'
        });
        $routeProvider.when('/PersonDashBoard', {
            templateUrl: '/Home/PersonDashboard',
            controller: 'personCtrl'
        });

        $routeProvider.otherwise({
            redirectTo: '/'
        });

        // Specify HTML5 mode (using the History APIs) or HashBang syntax.
        $locationProvider.html5Mode(false).hashPrefix('!');
    }]); 
}());


