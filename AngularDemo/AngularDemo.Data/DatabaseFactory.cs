using AngularDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Data
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private AdventureWorks2008R2Entities dataContext;
        public AdventureWorks2008R2Entities Get()
        {
            return dataContext ?? (dataContext = new AdventureWorks2008R2Entities());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
