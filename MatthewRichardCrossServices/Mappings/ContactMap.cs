using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Mappings 
{
    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Identity();
            Map(x => x.Forename);
            Map(x => x.Surname);
            Map(x => x.TelephoneNumber);
            Map(x => x.EmailAddress);
        }
    }
}