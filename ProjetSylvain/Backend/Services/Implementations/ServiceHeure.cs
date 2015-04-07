using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceHeure : Service, IServiceHeure
    {
		public ServiceHeure() : base()
        {
            // constructeur
        }

        public Heure Add(Heure h)
        {
            using (var context = EntityContainer.getInstance())
            {
                Heure heure;
                heure = context.HeureSet.Add(h);
                context.SaveChanges();
                return heure;
            }
        }

        public Heure Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.HeureSet.First(x => x.Id == id);
            }
        }

        public void Update(Heure h)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(h).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Heure heure = context.HeureSet.Find(id);
                context.HeureSet.Remove(heure);
                context.SaveChanges();
            }
        }
    }
}
