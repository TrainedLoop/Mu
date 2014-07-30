using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mu.Repository;

namespace Mu.Models
{
    public class Ranking
    {
        public static IList<Character> GetResetRanking(int size)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();


            return section.QueryOver<Character>().Where(i => i.Resets > 0).List().OrderByDescending(i => i.Resets).ToList().Take(size).ToList();
        }
    }
}