using Mu.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mu.Models
{
    public static class Login
    {
        
        public static MembInfo GetLoggedUser()
        {
            HttpCookie MyCookie = HttpContext.Current.Request.Cookies["BarretCookie"];
            if (MyCookie == null)
            {
                return null;
            }
            else
            {
                var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
                string login =  MyCookie["Email"];
                MembInfo user = section.QueryOver<MembInfo>().Where(i => i.MembId == login).SingleOrDefault();
                return user;
            }
        }

        public static bool LoginUser(string User, string Password)
        {
            var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
            var query = section.QueryOver<MembInfo>().Where(i => i.MembId == User && i.MembPwd == Password).SingleOrDefault();
            if (query == null)
            { return false; }
            HttpCookie MyCookie = new HttpCookie("BarretCookie");
            MyCookie["Email"] = query.MembId;
            MyCookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(MyCookie);
            return true;
        }


        public static void Logoff()
        {
            HttpCookie MyCookie = HttpContext.Current.Request.Cookies["BarretCookie"];

            if (MyCookie != null)
            {
                var section = Mu.MvcApplication.SessionFactory.GetCurrentSession();
                string login = MyCookie["Email"];
                var query = section.QueryOver<MembInfo>().Where(i => i.MembId == login).SingleOrDefault();
                MyCookie["Email"] = query.MembId;
                MyCookie.Expires = DateTime.Now.AddMilliseconds(500);
                HttpContext.Current.Response.Cookies.Add(MyCookie);
            }

        }

    }
}