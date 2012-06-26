using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Repositories.Interfaces
{
    public interface IPortfolioFullItemRepository
    {
        void Add(PortfolioFullItem portfolioFullItem);
        void Update(PortfolioFullItem portfolioFullItem);
        void Remove(PortfolioFullItem portfolioFullItem);
        PortfolioFullItem GetById(Int64 id);
        IList<PortfolioFullItem> GetByPortfolioSummaryItemId(Int64 portfolioSummaryItemId);
        IList<PortfolioFullItem> GetAll();
    }
}
