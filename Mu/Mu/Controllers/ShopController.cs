using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mu.Models;
using Mu.Repository;

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
        public ActionResult Bows()
        {
            var user = Login.GetLoggedUser();
            return View();
        }

        public ActionResult Staves()
        {
            var user = Login.GetLoggedUser();
            return View();
        }

        public ActionResult Scepters()
        {
            var user = Login.GetLoggedUser();
            return View();
        }

        public ActionResult Shilds()
        {
            var user = Login.GetLoggedUser();
            return View();
        }

        public ActionResult Spears()
        {
            var user = Login.GetLoggedUser();
            return View();
        }
        public ActionResult AddToCart(string itemName, decimal value, bool Add)
        {
            var user = Login.GetLoggedUser();
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var cart = new ShopItem()
            {
                IsClosed = false,
                Paid = false,
                Seeled = false,
                User = user,
                ItemName = itemName,
                ItemValue = Add ? value + 5 : value
            };
            section.Save(cart);

            return View("Index");
        }

    }
}
