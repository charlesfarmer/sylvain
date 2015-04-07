using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceProfesseur : Service, IServiceProfesseur
    {
		public ServiceProfesseur(EntityContainer context) : base(context)
        {
            // constructeur
        }

        public Professeur Add(Professeur p)
        {
            Professeur professeur;
                professeur = context.ProfesseurSet.Add(p);
                context.SaveChanges();
                return professeur;
        }

        public Professeur Get(int id)
        {
                return context.ProfesseurSet.First(x => x.Id == id);
        }

        public void Update(Professeur p)
        {
                context.Entry(p).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                Professeur professeur = context.ProfesseurSet.Find(id);
                context.ProfesseurSet.Remove(professeur);
                context.SaveChanges();
        }
    }
}
