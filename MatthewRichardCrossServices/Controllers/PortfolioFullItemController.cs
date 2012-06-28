using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatthewRichardCrossServices.Repositories.Interfaces;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Controllers
{
    public class PortfolioFullItemController : Controller
    {
        IPortfolioFullItemRepository _portfolioFullItemRepository;

        public PortfolioFullItemController(IPortfolioFullItemRepository portfolioFullItemRepository)
        {
            _portfolioFullItemRepository = portfolioFullItemRepository;
        }

        //
        // GET: /PortfolioFullItem/
        public ActionResult Index()
        {
            var model = _portfolioFullItemRepository.GetAll();
            return View(model);
        }

        //
        // GET: /PortfolioFullItem/Details/5
        public ActionResult Details(int id)
        {
            var model = _portfolioFullItemRepository.GetById(id);
            return View(model);
        }

        //
        // GET: /PortfolioFullItem/Create
        public ActionResult Create()
        {
            var model = new PortfolioFullItem();
            return View(model);
        } 

        //
        // POST: /PortfolioFullItem/Create
        [HttpPost]
        public ActionResult Create(PortfolioFullItem portfolioFullItem)
        {
            try
            {
                _portfolioFullItemRepository.Add(portfolioFullItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /PortfolioFullItem/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _portfolioFullItemRepository.GetById(id);
            return View(model);
        }

        //
        // POST: /PortfolioFullItem/Edit/5
        [HttpPost]
        public ActionResult Edit(PortfolioFullItem portfolioFullItem)
        {
            try
            {
                _portfolioFullItemRepository.Update(portfolioFullItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /PortfolioFullItem/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _portfolioFullItemRepository.GetById(id);
            return View(model);
        }

        //
        // POST: /PortfolioFullItem/Delete/5
        [HttpPost]
        public ActionResult Delete(PortfolioFullItem portfolioFullItem)
        {
            try
            {
                _portfolioFullItemRepository.Remove(portfolioFullItem);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}