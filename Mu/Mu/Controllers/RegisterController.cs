﻿using Mu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mu.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MuUser( Register register)
        {
            register.Save();
            return RedirectToAction("Index", "Home");
        }

    }
}
