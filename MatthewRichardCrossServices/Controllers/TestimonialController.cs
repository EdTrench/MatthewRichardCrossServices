using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatthewRichardCrossServices.Repositories.Interfaces;

namespace MatthewRichardCrossServices.Controllers
{
    public class TestimonialController : Controller
    {

        ITestimonialRepository _testimonialRepository;

        public TestimonialController(ITestimonialRepository testimonalRepository)
        {
            _testimonialRepository = testimonalRepository;
        }

        //
        // GET: /Testimonial/
        public ActionResult Index()
        {
            var testimonials = _testimonialRepository.GetAll();
            return View(testimonials);
        }

    }
}
