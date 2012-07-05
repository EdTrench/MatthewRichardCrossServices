using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Mappings
{
    public class TestimonialMap : ClassMap<Testimonial>
    {
        public TestimonialMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Identity();
            Map(x => x.CustomerName);
            Map(x => x.Title);
            Map(x => x.Description);
        }
    }
}