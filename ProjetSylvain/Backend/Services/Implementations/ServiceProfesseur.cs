﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceProfesseur : Service, IServiceProfesseur
    {
		public ServiceProfesseur() : base()
        {
            // constructeur
        }
		// Utiliser pour add un Professeur
        public Professeur Add(Professeur p)
        {
            using (var context = EntityContainer.getInstance())
            {
                Professeur professeur;
                professeur = context.ProfesseurSet.Add(p);
                context.SaveChanges();
                return professeur;
            }
        }
		// Utiliser pour get un Professeur
        public Professeur Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.ProfesseurSet.First(x => x.Id == id);
            }
        }
		// Utiliser pour update un Professeur
        public void Update(Professeur p)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(p).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }
		// Utiliser pour delete un Professeur
        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Professeur professeur = context.ProfesseurSet.Find(id);
                context.ProfesseurSet.Remove(professeur);
                context.SaveChanges();
            }
        }

		// Rechere les Prof. par critere ( ID,Nom,Prenom )
		public List<Professeur> FindByCritere(String typeDeRecherche, String texteATrouver) 
		{
			using (var context = EntityContainer.getInstance())
			{
                int texteATrouverint;
                Int32.TryParse(texteATrouver, out texteATrouverint);
				switch(typeDeRecherche){

					case "ID": return context.ProfesseurSet.Include("Coordonnees").Where(x => x.Id == texteATrouverint).ToList();

					case "Nom": return context.ProfesseurSet.Include("Coordonnees").Where(x => x.Coordonnees.Nom == texteATrouver).ToList();
						
					case "Prenom": return context.ProfesseurSet.Include("Coordonnees").Where(x => x.Coordonnees.Prenom == texteATrouver).ToList();

					default: return new List<Professeur>();

				}
				
			}
		}
    }
}
