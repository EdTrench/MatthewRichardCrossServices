using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Linq;
using MatthewRichardCrossServices.Repositories.Interfaces;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public void Add(Contact contact)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(contact);
                transaction.Commit();
            }
        }
    }
}