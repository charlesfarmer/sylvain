using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    public interface IServiceProfesseur : IService
    {
        Professeur Get(int id);
        Professeur Add(Professeur professeur);
        void Update(Professeur professeur);
        void Delete(int id);
		List<Professeur> FindByCritere(String typeDeRecherche, String texteATrouver);
    }
}
