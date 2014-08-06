using Mu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mu.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var user = Login.GetLoggedUser();
            if(user!=null)
            {
                var messages = new Message(user);
                return View(messages.GetMessages());
            }
            return View();
        }

    }
}
