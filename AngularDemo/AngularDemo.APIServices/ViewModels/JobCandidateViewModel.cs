using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.ViewModels
{
    public class JobCandidateViewModel
    {
        public int JobCandidateID { get; set; }
        public Nullable<int> BusinessEntityID { get; set; }
        public string Resume { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
    }
}