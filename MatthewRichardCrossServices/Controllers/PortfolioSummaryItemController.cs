using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatthewRichardCrossServices.Repositories.Interfaces;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Controllers
{
    public class PortfolioSummaryItemController : Controller
    {
        IPortfolioSummaryItemRepository _portfolioSummaryItemRepository;

        public PortfolioSummaryItemController(IPortfolioSummaryItemRepository portfolioSummaryItemRepository)
        {
            _portfolioSummaryItemRepository = portfolioSummaryItemRepository;
        }

        //
        // GET: /PortfolioSummaryItem/
        public ActionResult Index()
        {
            var model = _portfolioSummaryItemRepository.GetAll();
            return View(model);
        }

        //
        // GET: /PortfolioSummaryItem/Details/5
        public ActionResult Details(int id)
        {
            var model = _portfolioSummaryItemRepository.GetById(id);
            return View(model);
        }

        //
        // GET: /PortfolioSummaryItem/Create
        public ActionResult Create()
        {
            var model = new PortfolioFullItem();
            return View(model);
        } 

        //
        // POST: /PortfolioSummaryItem/Create
        [HttpPost]
        public ActionResult Create(PortfolioSummaryItem portfolioSummaryItem)
        {
            try
            {
                _portfolioSummaryItemRepository.Add(portfolioSummaryItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /PortfolioSummaryItem/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _portfolioSummaryItemRepository.GetById(id);
            return View(model);
        }

        //
        // POST: /PortfolioSummaryItem/Edit/5
        [HttpPost]
        public ActionResult Edit(PortfolioSummaryItem portfolioSummaryItem)
        {
            try
            {
                _portfolioSummaryItemRepository.Update(portfolioSummaryItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PortfolioSummaryItem/Delete/5
 
        public ActionResult Delete(int id)
        {
            var model = _portfolioSummaryItemRepository.GetById(id);
            return View(model);
        }

        //
        // POST: /PortfolioSummaryItem/Delete/5

        [HttpPost]
        public ActionResult Delete(PortfolioSummaryItem portfolioSummaryItem)
        {
            try
            {
                _portfolioSummaryItemRepository.Remove(portfolioSummaryItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}