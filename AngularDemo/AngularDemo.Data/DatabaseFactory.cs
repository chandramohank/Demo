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
        private AdventureWorks2012Entities dataContext;
        public AdventureWorks2012Entities Get()
        {
            return dataContext ?? (dataContext = new AdventureWorks2012Entities());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
