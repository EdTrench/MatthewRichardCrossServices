using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Linq;
using MatthewRichardCrossServices.Repositories.Interfaces;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Repositories
{
    public class TestimonialRepository : ITestimonialRepository
    {
        public IList<Testimonial> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var query = from testimonial in session.Query<Testimonial>()
                            select testimonial;
                return query.ToList();
            }
        }
    }
}