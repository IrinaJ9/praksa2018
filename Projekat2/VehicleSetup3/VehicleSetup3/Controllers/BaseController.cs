﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleSetup3.Models;

namespace VehicleSetup3.Controllers
{
    public class BaseController : Controller
    {
        public Entities db = new Entities();
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}