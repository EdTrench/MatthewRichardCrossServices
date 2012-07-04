using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MatthewRichardCrossServices.Models;

namespace MatthewRichardCrossServices.Repositories.Interfaces
{
    public interface IContactRepository
    {
        void Add(Contact Contact);
    }
}