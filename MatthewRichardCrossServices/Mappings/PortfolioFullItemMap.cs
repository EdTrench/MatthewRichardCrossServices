using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Mappings
{
    public class PortfolioFullItemMap : ClassMap<PortfolioFullItem>
    {
        public PortfolioFullItemMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Identity();
            References(x => x.PortfolioSummaryItem)
                .Not.LazyLoad()
                .Column("PortfolioSummaryItemId");
            Map(x => x.DescriptionText);
            Map(x => x.PhotographLocation);
        }
    }
}