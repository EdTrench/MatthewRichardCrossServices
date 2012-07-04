using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatthewRichardCrossServices.Repositories.Interfaces;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Controllers
{
    public class ContactController : Controller
    {
        IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        //
        // GET: /Contact/Create
        public ActionResult Create()
        {
            var model = new Contact();
            return View(model);
        }

        //
        // POST: /Contact/Create
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                _contactRepository.Add(contact);
                return View("Create");
            }
            catch
            {
                return View();
            }
        }
    }
}
