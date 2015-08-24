using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.ViewModels
{
    public class EmployeePayHistoryViewModel
    {
        public int BusinessEntityID { get; set; }
        public System.DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}