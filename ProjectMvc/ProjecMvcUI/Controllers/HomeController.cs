﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Data.Context;
using Project.Domin.Models;

namespace ProjecMvcUI.Controllers
{
    public class HomeController : Controller
    {
        Pro_DBEntitis db = new Pro_DBEntitis();

        // GET: Home
        public ActionResult Index()
        {
          
            return View(db.Roles.ToList());
        }
    }
}