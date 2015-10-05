using AngularDemo.APIServices.ViewModels;
using AngularDemo.Data;
using AngularDemo.Shared;
using AutoMapper;
using Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace AngularDemo.APIServices.Controllers
{
    public class PersonController : BaseController
    {
        IDashboardService dashboardService;
        public PersonController(IDashboardService dashboardService)
        {
            this.dashboardService = dashboardService;
        }

         //GET api/<controller>
        [MethodAspect]
        public async Task<IEnumerable<PersonViewModel>> Getsync()
        {
            
            var persons =await dashboardService.GetPersonsAsynch();
            return Mapper.Map<List<PersonViewModel>>(persons);          
            
        }

        [MethodAspect]
        public IEnumerable<PersonViewModel> GetPersons()
        {

            var persons = dashboardService.GetPersons();
            var personsviewmodels = new List<PersonViewModel>();
            Mapper.Map(persons, personsviewmodels);

            return personsviewmodels;
        }
    }
}