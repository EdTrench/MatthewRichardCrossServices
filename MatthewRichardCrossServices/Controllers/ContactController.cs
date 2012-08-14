using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatthewRichardCrossServices.Repositories.Interfaces;
using MatthewRichardCrossServices.Models;
using MatthewRichardCrossServices.Services.Email;
using MatthewRichardCrossServices.Helpers;

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
                if (ModelState.IsValid)
                {
                    _contactRepository.Add(contact);
                    Email.SendEmail("postmaster@" + Globals.MailGun_Domain_Name,
                        Globals.MRC_Email_Address,
                        contact.Id + ". New Contact Me Request on " + DateTime.Now,
                        contact.EmailContent);
                    return View("Received", contact);
                }
                return View(contact);
            }
            catch
            {
                return View();
            }
        }
    }
}
