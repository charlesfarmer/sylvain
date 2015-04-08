﻿using System;
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

        public Etudiant Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.EtudiantSet.First(x => x.Id == id);
            }
        }

        public void Update(Etudiant e)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(e).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

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
    }
}
