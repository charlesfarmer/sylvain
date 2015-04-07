using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    public interface IServiceHeure : IService
    {
        Heure Get(int id);
        Heure Add(Heure heure);
        void Update(Heure heure);
        void Delete(int id);
    }
}
