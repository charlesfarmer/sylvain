using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceCours : Service, IServiceCours
    {
		public ServiceCours() : base()
        {
            // constructeur
        }
		// Utiliser pour add un cours
        public Cours Add(Cours c)
        {
            using (var context = EntityContainer.getInstance())
            {
                Cours cours;
                cours = context.CoursSet.Add(c);
                context.SaveChanges();
                return cours;
            }
        }
		// Utiliser pour get un cours
        public Cours Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.CoursSet.Include("Inscription.Paiement").Include("Inscription.Etudiant.Coordonnees").Include("Inscription.Etudiant.Login").Include("Sujet").First(x => x.Id == id);
            }
        }
		// Utiliser pour update un cours
        public void Update(Cours c)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(c).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }
		// Utiliser pour delete un cours
        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Cours cours = context.CoursSet.Find(id);
                context.CoursSet.Remove(cours);
                context.SaveChanges();
            }
        }
		// revoie une List<Cours> valide pour s'inscrire 
        public List<Cours> GetAllAvailableForSubscription()
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.CoursSet.Include("Horaire.Jour").Include("Horaire.Heure").Include("Sujet").Include("Inscription.Paiement").Include("Inscription.Etudiant.Coordonnees").Include("Inscription.Etudiant.Login").Where(x => x.DateLimite > DateTime.Now).ToList();
            }
        }
    }
}
