using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    public interface IServiceLogin : IService
    {
        Login Get(int id);
        Login Add(Login login);
        void Update(Login login);
        void Delete(int id);
		List<Login> FindByCritere(String typeDeRecherche, String texteATrouver);

        // Business logic
        bool ValidateAdminLogin(Login login);

        Login FindByCodeAndPass(string code, string pass, bool hasToBeEtudiant);
    }
}
