using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatthewRichardCrossServices.Models
{
    public class Testimonial
    {
        public virtual Int64 Id { get; set; }
        public virtual String CustomerName { get; set; }
        public virtual String Title { get; set; }
        public virtual String Description { get; set; }
    }
}