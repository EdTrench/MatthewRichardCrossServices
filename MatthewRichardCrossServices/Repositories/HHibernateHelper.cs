using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;

using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Repositories
{
    public class HHibernateHelper
    {
        private static ISessionFactory SessionFactory
        {
            get
            {
                return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(m => m.Server(@"6335c281-0269-44e7-bc3f-a07c00f84164.sqlserver.sequelizer.com")
                        .Database("db6335c281026944e7bc3fa07c00f84164")
                        .Username("aawklaokwdhkyiis")
                        .Password("mrVds4YmzY64ekHnCEEUR27DjjpaCjtBPf4jHWwfjP7KeMuRGd3zXHbstq2iMXRq")))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildSessionFactory();
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}