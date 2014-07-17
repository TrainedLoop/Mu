
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Mu;

namespace Mu
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static ISessionFactory SessionFactory { get; private set; }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

#if (DEBUG)
            SessionFactory = Fluently.Configure()
              .Database(
                MsSqlConfiguration.MsSql2008.ConnectionString
                (c => c.Server("mubangu.servegame.com").Database("MuOnline").Username("sa").Password("cel96558618*"))
                .ShowSql().FormatSql())
                .Mappings(i => i.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(c => c.SetProperty("current_session_context_class", "web"))
                .ExposeConfiguration(c => c.Properties.Add("hbm2ddl.keywords", "none"))
                .ExposeConfiguration(c => new SchemaUpdate(c).Execute(true, true))
                .BuildSessionFactory();

            log4net.Config.XmlConfigurator.Configure();
#endif

#if (!DEBUG)
            SessionFactory = Fluently.Configure()
              .Database(
               MsSqlConfiguration.MsSql2008.ConnectionString
                (c => c.Server("mubangu.servegame.com").Database("MuOnline").Username("sa").Password("cel96558618*")))
                .Mappings(i => i.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .ExposeConfiguration(c => c.SetProperty("current_session_context_class", "web"))
                .ExposeConfiguration(c => c.Properties.Add("hbm2ddl.keywords", "none"))
                .ExposeConfiguration(c => new SchemaUpdate(c).Execute(true, true))
                .BuildSessionFactory();
#endif
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            var session = SessionFactory.OpenSession();
            CurrentSessionContext.Bind(session);


        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            var session = CurrentSessionContext.Unbind(SessionFactory);
            session.Flush();
            session.Dispose();

        }
    }
}
