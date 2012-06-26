using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatthewRichardCrossServices.Models
{
    public class PortfolioSummaryItem
    {
        public virtual Int64 Id { get; set; }
        public virtual String Name { get; set; }
        public virtual String DescriptionText { get; set; }
        public virtual String PhotographLocation { get; set; }
    }
}