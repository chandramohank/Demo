﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularDemo.Web.Controller
{
    public class HomeController : System.Web.Mvc.Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmplyeeDashBoard()
        {
            return PartialView("EmplyeeDashBoard");
        }
        public ActionResult addEmployee()
        {
            return PartialView("addEmployee");
        }
        public ActionResult editEmployee()
        {
            return PartialView("editEmployee");
        }
        public ActionResult PersonDashboard()
        {
            return PartialView("personDashboard");
        }
	}
}