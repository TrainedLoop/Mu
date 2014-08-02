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
            ShopKart cart = section.QueryOver<ShopKart>().Where(i => i.User == user).SingleOrDefault();
            if (cart == null)
                cart = new ShopKart() { User = user };

            if (cart.Requests == null)
            {
                cart.Requests = new List<ShopRequest>();
                section.Save(cart);
                section.Flush();
            }

            var item = section.QueryOver<ShopItem>().Where(i => i.ItemName == itemName && i.ItemValue == (Add ? value + 5 : value)).SingleOrDefault();
            if (item == null)
            {
                item = new ShopItem()
                {
                    ItemName = itemName,
                    ItemValue = Add ? value + 5 : value

                };
                section.Save(item);
                section.Flush();
            }
            cart.Requests.Add(new ShopRequest { Cart = cart, Item = item });


            return View("Index");
        }

    }
}
