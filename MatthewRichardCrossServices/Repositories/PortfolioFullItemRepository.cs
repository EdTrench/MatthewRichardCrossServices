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
    public class PortfolioFullItemRepository : IPortfolioFullItemRepository
    {
        public void Add(PortfolioFullItem portfolioFullItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(portfolioFullItem);
                transaction.Commit();
            }
        }

        public void Update(PortfolioFullItem portfolioFullItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(portfolioFullItem);
                transaction.Commit();
            }
        }

        public void Remove(PortfolioFullItem portfolioFullItem)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(portfolioFullItem);
                transaction.Commit();
            }
        }

        public PortfolioFullItem GetById(long id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from portfolioFullItem in session.Query<PortfolioFullItem>()
                            where portfolioFullItem.Id == id
                            select portfolioFullItem;
                return query.Single();
            }
        }

        public IList<PortfolioFullItem> GetByPortfolioSummaryItemId(long portfolioSummaryItemId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from portfolioFullItem in session.Query<PortfolioFullItem>()
                            where portfolioFullItem.PortfolioSummaryItem.Id == portfolioSummaryItemId
                            select portfolioFullItem;
                return query.ToList();
            }
        }

        public IList<PortfolioFullItem> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from portfolioFullItem in session.Query<PortfolioFullItem>()
                            select portfolioFullItem;
                return query.ToList();
            }
        }
    }
}