using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.ViewModels
{
    public class ShiftViewModel
    {
        public byte ShiftID { get; set; }
        public string Name { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}