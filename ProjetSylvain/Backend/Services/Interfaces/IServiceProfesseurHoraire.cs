using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    public interface IServiceProfesseurHoraire : IService
    {
        ProfesseurHoraire Get(int id);
        ProfesseurHoraire Add(ProfesseurHoraire professeurHoraire);
        void Update(ProfesseurHoraire professeurHoraire);
        void Delete(int id);
    }
}
