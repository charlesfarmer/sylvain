using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    interface IServiceEtudiant : IService
    {
        Etudiant Get(int id);
        Etudiant Add(Etudiant etudiant);
        void Update(Etudiant etudiant);
        void Delete(Etudiant etudiant);
    }
}
