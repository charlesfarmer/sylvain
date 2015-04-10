using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    public interface IServiceCours : IService
    {
        Cours Get(int id);
        Cours Add(Cours cours);
        void Update(Cours cours);
        void Delete(int id);
        List<Cours> GetAllAvailableForSubscription();

    }
}
