using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Linq;
using MatthewRichardCrossServices.Repositories.Interfaces;


namespace MatthewRichardCrossServices.Repositories
{
    public class PortfolioFullItemRepository : IPortfolioFullItemRepository
    {
        public void Add(Models.PortfolioFullItem portfolioFullItem)
        {
            throw new NotImplementedException();
        }

        public void Update(Models.PortfolioFullItem portfolioFullItem)
        {
            throw new NotImplementedException();
        }

        public void Remove(Models.PortfolioFullItem portfolioFullItem)
        {
            throw new NotImplementedException();
        }

        public Models.PortfolioFullItem GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Models.PortfolioFullItem> GetByPortfolioSummaryItemId(long portfolioSummaryItemId)
        {
            throw new NotImplementedException();
        }

        public IList<Models.PortfolioFullItem> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}