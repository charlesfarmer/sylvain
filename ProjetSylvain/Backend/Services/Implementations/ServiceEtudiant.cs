using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceEtudiant : Service, IServiceEtudiant
    {
		public ServiceEtudiant() : base()
        {
            // constructeur
        }
		// Utiliser pour add un étudiant
        public Etudiant Add(Etudiant e)
        {
            using (var context = EntityContainer.getInstance())
            {
                Etudiant etudiant;
                etudiant = context.EtudiantSet.Add(e);
                context.SaveChanges();
                return etudiant;
            }
        }
		// Utiliser pour get un étudiant
        public Etudiant Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.EtudiantSet.First(x => x.Id == id);
            }
        }
		// Utiliser pour update un étudiant
        public void Update(Etudiant e)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(e).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }
		// Utiliser pour delete un étudiant
        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Etudiant etudiant = context.EtudiantSet.Find(id);
                context.EtudiantSet.Remove(etudiant);
                context.SaveChanges();
            }
        }

		// Rechere les Etudiant par critere
		public List<Etudiant> FindByCritere(String typeDeRecherche, String texteATrouver)
		{
			using (var context = EntityContainer.getInstance())
			{

				switch (typeDeRecherche)
				{

					case "ID": return context.EtudiantSet.Where(x => x.Id == Int32.Parse(texteATrouver)).ToList();

					case "Nom": return context.EtudiantSet.Where(x => x.Coordonnees.Nom == texteATrouver).ToList();

					case "Prenom": return context.EtudiantSet.Where(x => x.Coordonnees.Prenom == texteATrouver).ToList();

					default: return new List<Etudiant>();

				}

			}
		}
        public Etudiant AddNewEtudiant(int coordonneesId, int loginId)
        {
            using (var context = EntityContainer.getInstance())
            {
                Etudiant e = new Etudiant();
                e.Coordonnees = context.CoordonneesSet.Single(x => x.Id == coordonneesId);
                e.Login = context.LoginSet.Single(x => x.Id == loginId);

                Etudiant eReturn;
                eReturn = context.EtudiantSet.Add(e);
                context.SaveChanges();
                return eReturn;
            }
        }
    }
}
