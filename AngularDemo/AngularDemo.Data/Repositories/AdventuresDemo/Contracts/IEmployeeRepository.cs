using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Data.Repositories
{
    public interface IEmployeeRepository
    {
        List<AngularDemo.Entities.Models.Employee> GetEmployees();
        AngularDemo.Entities.Models.Employee getEmployee(string id);
    }
}
