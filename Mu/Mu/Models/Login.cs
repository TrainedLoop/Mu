using Mu.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Models
{
    public static class Login
    {
        public static MEMB_INFO GetLoggedUser()
        {
            HttpCookie MyCookie = HttpContext.Current.Request.Cookies["BarretCookie"];
            if (MyCookie == null)
            {
                return null;
            }
            else
            {
                string login =  MyCookie["Email"];
                MEMB_INFO user = new MuOnlineEntities().MEMB_INFO.Where(i => i.memb___id == login).FirstOrDefault();
                return user;
            }
        }

        public static bool LoginUser(string User, string Password)
        {
            var query = new MuOnlineEntities().MEMB_INFO.Where(i => i.memb___id == User && i.memb__pwd == Password).FirstOrDefault();
            if (query == null)
            { return false; }
            HttpCookie MyCookie = new HttpCookie("BarretCookie");
            MyCookie["Email"] = query.memb___id;
            MyCookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(MyCookie);
            return true;
        }


        public static void Logoff()
        {
            HttpCookie MyCookie = HttpContext.Current.Request.Cookies["BarretCookie"];

            if (MyCookie != null)
            {
                var query = new MuOnlineEntities().MEMB_INFO.Where(i => i.memb___id == MyCookie["Email"]).SingleOrDefault();
                MyCookie["Email"] = query.memb___id;
                MyCookie.Expires = DateTime.Now.AddMilliseconds(500);
                HttpContext.Current.Response.Cookies.Add(MyCookie);
            }

        }

    }
}