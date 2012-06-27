using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.ViewModels
{
    public class PortfolioItemViewModel
    {
        public virtual PortfolioSummaryItem PortfolioSummaryItem { get; set; }
        public virtual SelectList PortfolioFullItem { get; set; }
    }
}