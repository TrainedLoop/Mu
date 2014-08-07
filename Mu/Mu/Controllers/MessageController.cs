using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mu.Models;

namespace Mu.Controllers
{
    public class MessageController : Controller
    {
        //
        // GET: /Message/

        public ActionResult SendMessageToADM()
        {
            var user = Login.GetLoggedUser();
            if (user == null)
                throw new Exception("Usuario não Logado");
            return View(user);
        }
        [HttpPost]
        public ActionResult SendMessageToADM(string message)
        {
            var user = Login.GetLoggedUser();
            if (user == null)
                throw new Exception("Usuario não Logado");
            Message msg = new Message(user);
            msg.SendMessageToAdm(message);
            ViewBag.Result = "Mensagem enviada com sucesso!";
            return View(user);
        }

    }
}
