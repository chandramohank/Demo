using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Data.Repositories.AdventuresDemo
{
    public class DashboardRepository : RepositoryBase<Person>, IDashboardRepository
    {
       
        public DashboardRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
            
        }
    }
}
