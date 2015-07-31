using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Entities.Models
{
    public class Employee
    {
        public string _id { get; set; }
        public int index { get; set; }
        public Guid guid { get; set; }
        public bool isActive { get; set; }
        public double balance { get; set; }
        public int age { get; set; }
        public string picture { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

    }
}
