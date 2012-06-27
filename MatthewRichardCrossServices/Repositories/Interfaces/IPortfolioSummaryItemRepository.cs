using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Repositories.Interfaces
{
    public interface IPortfolioSummaryItemRepository
    {
        void Add(PortfolioSummaryItem portfolioSummaryItem);
        void Update(PortfolioSummaryItem portfolioSummaryItem);
        void Remove(PortfolioSummaryItem portfolioSummaryItem);
        PortfolioSummaryItem GetById(Int64 id);
        IList<PortfolioSummaryItem> GetAll();
    }
}
