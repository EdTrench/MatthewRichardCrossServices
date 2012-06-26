using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatthewRichardCrossServices.Models
{
    public class PortfolioFullItem
    {
        public virtual Int64 Id { get; set; }
        public virtual Int64 PortfolioSummaryItemId { get; set; }
        public virtual String DescriptionText { get; set; }
        public virtual String PhotographLocation { get; set; }
    }
}