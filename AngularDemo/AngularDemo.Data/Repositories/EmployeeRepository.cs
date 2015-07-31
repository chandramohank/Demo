using AngularDemo.Data.Shared_Classes;
using AngularDemo.Entities.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Data.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            var empList = new List<Employee>() { };
            string exe_path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            dynamic obj= JObject.Parse(File.ReadAllText(exe_path + @"\datasource.txt"));
            return empList;
        }
    }
}
