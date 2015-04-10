using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
	// Interface pour IServiceEtudiant
    public interface IServiceEtudiant : IService
    {
        Etudiant Get(int id);
        Etudiant Add(Etudiant etudiant);
        void Update(Etudiant etudiant);
        void Delete(int id);
		List<Etudiant> FindByCritere(String typeDeRecherche, String texteATrouver);
    }
}
