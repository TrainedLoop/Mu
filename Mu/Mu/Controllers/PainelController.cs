using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mu.Models;
using Mu.Repository;

namespace Mu.Controllers
{
    public class PainelController : Controller
    {
        //
        // GET: /Painel/

        public ActionResult Index()
        {
            Painel painel = new Painel(Login.GetLoggedUser());
            return View(painel.GetCharacters());
        }

        public ActionResult Reset(string CharName)
        {
            var user = Login.GetLoggedUser();
            Painel painel = new Painel(Login.GetLoggedUser());
            ViewBag.Result = painel.Reset(CharName);
            return View("Index",painel.GetCharacters());
        }

    }
}
