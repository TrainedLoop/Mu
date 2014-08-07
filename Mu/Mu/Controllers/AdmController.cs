using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mu.Models;
using Mu.Repository;

namespace Mu.Controllers
{
    public class AdmController : Controller
    {
        //
        // GET: /Adm/

        public ActionResult Index()
        {
            var user = Login.GetLoggedUser();
            if (user.isAdm == false)
                throw new Exception("Sem Privilegios de ADM");

            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            return View(section.QueryOver<MembInfo>().List().Select(i => i.MembId).ToList());
        }
        [HttpPost]
        public ActionResult SendMSGToPlayer(string UserName, string message)
        {
            var user = Login.GetLoggedUser();
            if (user.isAdm == false)
                throw new Exception("Sem Privislegios de ADM");
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();

            var msgTo = section.QueryOver<MembInfo>().Where(i => i.MembId == UserName).SingleOrDefault();

            Mu.Models.Message.SendMessagePlayer(message, msgTo);
            return View("Index", section.QueryOver<MembInfo>().List().Select(i => i.MembId).ToList());
        }

    }
}
