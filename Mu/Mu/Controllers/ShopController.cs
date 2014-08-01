using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mu.Models;

namespace Mu.Controllers
{
    public class ShopController : Controller
    {
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            var user = Login.GetLoggedUser();
            return View();
        }
        public ActionResult BK()
        {
            var user = Login.GetLoggedUser();
            return View();
        }

        public ActionResult SM()
        {
            var user = Login.GetLoggedUser();
            return View();
        }
        public ActionResult ME()
        {
            var user = Login.GetLoggedUser();
            return View();
        }
        public ActionResult MG()
        {
            var user = Login.GetLoggedUser();
            return View();
        }
        public ActionResult DL()
        {
            var user = Login.GetLoggedUser();
            return View();
        }


        public ActionResult Swords()
        {
            var user = Login.GetLoggedUser();
            return View();
        }
        public ActionResult Axes()
        {
            var user = Login.GetLoggedUser();
            return View();
        }
        public ActionResult Maces()
        {
            var user = Login.GetLoggedUser();
            return View();
        }
    }
}
