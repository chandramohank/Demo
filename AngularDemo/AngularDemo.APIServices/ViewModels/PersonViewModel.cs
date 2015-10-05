using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.ViewModels
{
    public class PersonViewModel
    {
        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public EmployeeViewModel Employee { get; set; }
        public BusinessEntityViewModel BusinessEntity { get; set; }
        public ICollection<EmailAddressViewModel> EmailAddresses { get; set; }
        public PasswordViewModel Password { get; set; }
        public ICollection<PersonPhoneViewModel> PersonPhones { get; set; }
    }
}