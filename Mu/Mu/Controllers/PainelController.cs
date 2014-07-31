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
            return View("Index", painel.GetCharacters());
        }

        public ActionResult DeleteChar(string CharName)
        {
            var user = Login.GetLoggedUser();
            Painel painel = new Painel(Login.GetLoggedUser());
            painel.DeleteChar(CharName);
            return View("Index", painel.GetCharacters());
        }

        public ActionResult DistributorPoints(string CharName)
        {
            var user = Login.GetLoggedUser();
            Painel painel = new Painel(Login.GetLoggedUser());


            return View(painel.GetCharacters().Where(i => i.Name == CharName).SingleOrDefault());
        }

        [HttpPost]
        public ActionResult AddPoints(string CharName, int strength = 0, int agility = 0, int vitality = 0, int energy = 0)
        {
            var user = Login.GetLoggedUser();
            Painel painel = new Painel(Login.GetLoggedUser());
            var character = painel.GetCharacters().Where(i => i.Name == CharName).SingleOrDefault();
            try
            {

                painel.DistributePoints(CharName, strength, agility, vitality, energy);
                ViewBag.Save = "Pontos Distribuidos";
                return View("DistributorPoints", character);

            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("DistributorPoints", character);
            }
        }

        [HttpPost]
        public ActionResult Team(string CharName)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            Painel painel = new Painel(Login.GetLoggedUser());
            var character = painel.GetCharacters().Where(i => i.Name == CharName).SingleOrDefault();
            ViewBag.CharName = CharName;
            if (character.MemberOfTeam != null)
            {
                if (character.MemberOfTeam.Lider == character)
                    ViewBag.Request = section.QueryOver<TeamMemberRequests>().Where(i => i.Closed == false && i.Team == character.MemberOfTeam).List();
                return View(character.MemberOfTeam);
            }
            ViewBag.Teams = section.QueryOver<Team>().Where(i => !i.IsFull).List();
            return View();

        }

        public ActionResult ApplyToTeam(string CharName, int teamId)
        {
            Painel painel = new Painel(Login.GetLoggedUser());
            try
            {
                painel.ApllyToTeam(CharName, teamId);
                ViewBag.Result = "Sucesso";
                return View("Index", painel.GetCharacters());
            }
            catch (Exception ex)
            {
                ViewBag.Result = ex.Message;
                return View("Index", painel.GetCharacters());
            }

        }


        public ActionResult AcceptApply(int requestId)
        {
            Painel painel = new Painel(Login.GetLoggedUser());
            try
            {
                painel.AccepApplyToTeam(requestId);
                ViewBag.Result = "Sucesso";
                return View("Index", painel.GetCharacters());
            }
            catch (Exception ex)
            {
                ViewBag.Result = ex.Message;
                return View("Index", painel.GetCharacters());
            }

        }


        public ActionResult CreateTeam(string charName, string teamName)
        {
            Painel painel = new Painel(Login.GetLoggedUser());
            try
            {
                painel.CreateTeam(charName, teamName);
                ViewBag.Result = "Sucesso";
                return View("Index", painel.GetCharacters());
            }
            catch (Exception ex)
            {
                ViewBag.Result = ex.Message;
                return View("Index", painel.GetCharacters());
            }

        }
    }
}
