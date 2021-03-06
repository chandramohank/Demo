﻿using AngularDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IDashboardService
    {
        IEnumerable<Person> GetPersons();

        Task<IEnumerable<Person>> GetPersonsAsynch();
    }
}
