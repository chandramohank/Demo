using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.ViewModels
{
    public class PasswordViewModel
    {
        public int BusinessEntityID { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}