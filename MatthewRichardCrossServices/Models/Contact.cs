using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatthewRichardCrossServices.Models
{
    public class Contact
    {
        public virtual Int64 Id { get; set; }
        public virtual String Forename { get; set; }
        public virtual String Surname { get; set; }
        public virtual String TelephoneNumber { get; set; }
        public virtual String EmailAddress { get; set; }
    }
}