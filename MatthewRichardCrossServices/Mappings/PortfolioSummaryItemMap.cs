using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Mappings
{
    public class PortfolioSummaryItemMap : ClassMap<PortfolioSummaryItem>
    {
        public PortfolioSummaryItemMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Identity();
            HasMany(x => x.PortfolioFullItems)
                .Not.LazyLoad()
                .KeyColumn("Id")
                .Inverse();
            Map(x => x.DescriptionText);
            Map(x => x.Name);
            Map(x => x.PhotographLocation);
        }
    }
}