using AngularDemo.Data.Repositories;
using AngularDemo.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularDemo.APIServices.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public List<Employee> GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }
    }
}
