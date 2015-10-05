(function () {
    var app = angular.module("EmployeeModule");
    app.factory('personService', personRepository);
    personRepository.$inject = ['$http', '$q', 'appVariables'];
    function personRepository($http, $q, appVariables) {
        // interface
        var service = {
            get: get
           
        };
        return service;

        // implementation
        function get() {
            var def = $q.defer();
            $http.get(appVariables.GetPersonsURL)
                .success(function (data) {
                    //service.albums = data;
                    def.resolve(data);
                })
                .error(function () {
                    def.reject("Failed to get albums");
                });
            return def.promise;
        }
    }
})();