using System;
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

        public Professeur Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.ProfesseurSet.First(x => x.Id == id);
            }
        }

        public void Update(Professeur p)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(p).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Professeur professeur = context.ProfesseurSet.Find(id);
                context.ProfesseurSet.Remove(professeur);
                context.SaveChanges();
            }
        }
    }
}
