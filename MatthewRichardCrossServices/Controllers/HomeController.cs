using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatthewRichardCrossServices.Repositories.Interfaces;

namespace MatthewRichardCrossServices.Controllers
{
    public class HomeController : Controller
    {
        IPortfolioSummaryItemRepository _portfolioSummaryItemRepository;

        public HomeController(IPortfolioSummaryItemRepository portfolioSummaryItemRepository)
        {
            _portfolioSummaryItemRepository = portfolioSummaryItemRepository;
        }

        public ActionResult Index()
        {
            //ViewBag.Message = "Welcome to Matthew Richard Cross Services ";
            //return View();

            var model = _portfolioSummaryItemRepository.GetAll();
            return View(model);

        }

        public ActionResult About()
        {
            return View();
        }
    }
}
