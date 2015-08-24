using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.ViewModels
{
    public class DepartmentViewModel
    {
        public short DepartmentID { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}