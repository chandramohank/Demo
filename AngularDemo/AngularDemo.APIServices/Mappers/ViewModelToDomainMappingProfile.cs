using AngularDemo.APIServices.ViewModels;
using AngularDemo.Data;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularDemo.APIServices.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "ViewModelToDomainMappingProfile";
            }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<PersonViewModel,Person>();
            Mapper.CreateMap<EmployeeViewModel,Employee >();
            Mapper.CreateMap<BusinessEntityViewModel,BusinessEntity>();
            Mapper.CreateMap<BusinessEntityContactViewModel,BusinessEntityContact>();
            Mapper.CreateMap<EmailAddressViewModel,EmailAddress>();
            Mapper.CreateMap<PasswordViewModel,Password>();
            Mapper.CreateMap<PersonPhoneViewModel,PersonPhone>();
            Mapper.CreateMap<EmployeeDepartmentHistoryViewModel, EmployeeDepartmentHistory>();
            Mapper.CreateMap<EmployeePayHistoryViewModel, EmployeePayHistory>();
            Mapper.CreateMap<JobCandidateViewModel, JobCandidate>();
            Mapper.CreateMap<AddressTypeViewModel, AddressType>();
            Mapper.CreateMap<AddressViewModel, Address>();
            Mapper.CreateMap<BusinessEntityAddressViewModel, BusinessEntityAddress>(); 
            Mapper.CreateMap<ContactTypeViewModel, ContactType>();
            Mapper.CreateMap<DepartmentViewModel, Department>();
            Mapper.CreateMap<ShiftViewModel, Shift>();
        }
    }
}