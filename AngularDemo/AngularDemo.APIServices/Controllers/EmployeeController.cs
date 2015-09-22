using AngularDemo.Data.Repositories;
using AngularDemo.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using AngularDemo.Shared;

namespace AngularDemo.APIServices.Controllers
{
    public class EmployeeController : BaseController
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        [MethodAspect]
        public List<Employee> GetEmployees()
        {                       
            
            return _employeeRepository.GetEmployees();
        }

        public Employee getEmployee(string id)
        {
            return _employeeRepository.getEmployee(id);
        }
        //public override Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext controllerContext, CancellationToken cancellationToken)
        //{
        //    return base.ExecuteAsync(controllerContext, cancellationToken);
        //}
    }
}
