using AngularDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemo.Data
{
    public interface IDatabaseFactory:IDisposable
    {
        AdventureWorks2012Entities Get();
    }
}
