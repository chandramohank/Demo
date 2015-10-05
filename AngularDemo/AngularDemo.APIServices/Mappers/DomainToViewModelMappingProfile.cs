using AngularDemo.APIServices.ViewModels;
using AngularDemo.Data;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappingProfile";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Person, PersonViewModel>();
            Mapper.CreateMap<Employee, EmployeeViewModel>();
            Mapper.CreateMap<BusinessEntity, BusinessEntityViewModel>();
            Mapper.CreateMap<BusinessEntityContact, BusinessEntityContactViewModel>();
            Mapper.CreateMap<EmailAddress, EmailAddressViewModel>();
            Mapper.CreateMap<Password, PasswordViewModel>();
            Mapper.CreateMap<PersonPhone, PersonPhoneViewModel>();
            Mapper.CreateMap<EmployeeDepartmentHistory, EmployeeDepartmentHistoryViewModel>();
            Mapper.CreateMap<EmployeePayHistory, EmployeePayHistoryViewModel>();
            Mapper.CreateMap<JobCandidate, JobCandidateViewModel>();
            Mapper.CreateMap<AddressType, AddressTypeViewModel>();
            Mapper.CreateMap<Address, AddressViewModel>();
            Mapper.CreateMap<BusinessEntityAddress, BusinessEntityAddressViewModel>();
            Mapper.CreateMap<ContactType, ContactTypeViewModel>();
            Mapper.CreateMap<Department, DepartmentViewModel>();
            Mapper.CreateMap<Shift, ShiftViewModel>();
        }
    }
}