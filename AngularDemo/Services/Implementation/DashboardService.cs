using AngularDemo.Data;
using AngularDemo.Data.Repositories;
using AngularDemo.Data.Repositories.AdventuresDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DashboardService:IDashboardService
    {
        IDashboardRepository dashboardRepository;
        IUnitOfWork unitOfWork;
        public DashboardService(IDashboardRepository dashboardRepository, IUnitOfWork unitOfWork)
        {
            this.dashboardRepository = dashboardRepository;
            this.unitOfWork = unitOfWork;
        }
        public IEnumerable<Person> GetPersons()
        {
            return dashboardRepository.GetAll();
        }
    }
}
