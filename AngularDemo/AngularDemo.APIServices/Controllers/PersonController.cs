using AngularDemo.APIServices.ViewModels;
using AngularDemo.Shared;
using AutoMapper;
using Services;
using System.Collections.Generic;
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

        // GET api/<controller>
        [MethodAspect]
        public IEnumerable<PersonViewModel> Get()
        {
            var persons = dashboardService.GetPersons();
            var personsviewmodels = new List<PersonViewModel>();
            Mapper.Map(persons, personsviewmodels);

            return personsviewmodels;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}