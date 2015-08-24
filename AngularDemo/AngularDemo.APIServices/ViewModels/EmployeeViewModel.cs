using AngularDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.ViewModels
{
    public class EmployeeViewModel
    {
        public int BusinessEntityID { get; set; }
        public string NationalIDNumber { get; set; }
        public string LoginID { get; set; }
        public Nullable<short> OrganizationLevel { get; set; }
        public string JobTitle { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public System.DateTime HireDate { get; set; }
        public bool SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public  ICollection<EmployeeDepartmentHistoryViewModel> EmployeeDepartmentHistories { get; set; }
        public  ICollection<EmployeePayHistoryViewModel> EmployeePayHistories { get; set; }
        public  ICollection<JobCandidateViewModel> JobCandidates { get; set; }
    }
}