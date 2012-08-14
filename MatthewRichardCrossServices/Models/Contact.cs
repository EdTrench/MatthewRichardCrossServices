using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MatthewRichardCrossServices.Models
{
    public class Contact
    {
        public virtual Int64 Id { get; set; }
        [Required(ErrorMessage = "Please provide your {0}")]
        public virtual String Forename { get; set; }
        [Required(ErrorMessage = "Please provide your {0}")]
        public virtual String Surname { get; set; }
        [Required(ErrorMessage = "Please provide your {0}")]
        [Display(Name="Telephone Number")]
        [DataType(DataType.PhoneNumber)]
        public virtual String TelephoneNumber { get; set; }
        [Required(ErrorMessage = "Please provide your {0}")]
        [Display(Name="Email Address")]
        [DataType(DataType.EmailAddress)]
        public virtual String EmailAddress { get; set; }
        [DataType(DataType.MultilineText)]
        public virtual String Message { get; set; }
        public virtual String EmailContent  
        {
            get{return "Forename: " + Forename + ", Surname: " + Surname + ", Telephone Number: " + TelephoneNumber + ", Email Address : " + EmailAddress + ", Message : " + Message;}
        }

    }
}