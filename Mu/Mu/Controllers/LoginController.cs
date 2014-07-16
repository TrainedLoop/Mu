using Mu.Models;
using Mu.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mu.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();

        }
        public ActionResult MuUser(string User, string Password)
        {
            Login.LoginUser(User, Password);
            return RedirectToAction("Index","Home");
        }


       

      


    }
}
