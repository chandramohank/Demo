using AngularDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AdventureWorks2012Entities dbContext;
        private readonly IDatabaseFactory dbFactory;
        protected AdventureWorks2012Entities DbContext
        {
            get
            {
                return dbContext ?? dbFactory.Get();
            }
        }

        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
