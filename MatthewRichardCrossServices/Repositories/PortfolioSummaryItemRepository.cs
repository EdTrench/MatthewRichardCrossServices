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
    public class PortfolioSummaryItemRepository : IPortfolioSummaryItemRepository
    {
        public void Add(PortfolioSummaryItem portfolioSummaryItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(portfolioSummaryItem);
                transaction.Commit();
            }
        }

        public void Update(PortfolioSummaryItem portfolioSummaryItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(portfolioSummaryItem);
                transaction.Commit();
            }
        }

        public void Remove(PortfolioSummaryItem portfolioSummaryItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(portfolioSummaryItem);
                transaction.Commit();
            }
        }

        public PortfolioSummaryItem GetById(long id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from portfolioSummaryItem in session.Query<PortfolioSummaryItem>()
                              where portfolioSummaryItem.Id == id
                              select portfolioSummaryItem;
                return query.Single();
            }
        }

        public IList<PortfolioSummaryItem> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from portfolioSummaryItem in session.Query<PortfolioSummaryItem>()
                            select portfolioSummaryItem;
                return query.ToList();
            }
        }
    }
}