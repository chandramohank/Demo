using AngularDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.ViewModels
{
    public class BusinessEntityViewModel
    {
        public int BusinessEntityID { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public  ICollection<BusinessEntityAddressViewModel> BusinessEntityAddresses { get; set; }
        public  ICollection<BusinessEntityContactViewModel> BusinessEntityContacts { get; set; }       
    }
}