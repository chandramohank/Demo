(function () {
    var app = angular.module('EmployeeModule');

    app.constant('appVariables', {
        mongoApiUrl: 'https://api.mongolab.com/api/1/databases/{0}/collections/{1}?apiKey={2}',
        database: 'employeeinfo',
        EmpTable: 'Employee',
        apiKey: 'of3gLpBty3-W1nEsvNGsN7h4X4fYCcXD',
        //Employee MongoDB URLSs

        insertEmployeeURL: 'https://api.mongolab.com/api/1/databases/{0}/collections/{1}?apiKey={2}',
        updateEmployeeURL: 'https://api.mongolab.com/api/1/databases/{0}/collections/{1}/{2}?apiKey={3}',
        getEmployeeURL: 'https://api.mongolab.com/api/1/databases/{0}/collections/{1}?q={"_id":"{2}"}&fo=true&apiKey={3}',
        deleteEmployeeURL: 'https://api.mongolab.com/api/1/databases/{0}/collections/{1}/{2}?apiKey={3}',

        //AdventuresDB API URLs
        GetPersonsURL: 'http://localhost:64059/api/person/getsync'
    });
}());
