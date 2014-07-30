using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mu.Models;

namespace Mu.Controllers
{
    public class RankingController : Controller
    {
        //
        // GET: /Ranking/

        public ActionResult Reset()
        {

            return View(Ranking.GetResetRanking(50));
        }

    }
}
