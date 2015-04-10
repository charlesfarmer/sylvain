using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceJour : Service, IServiceJour
    {
		public ServiceJour() : base()
        {
            // constructeur
        }
		// Utiliser pour add un jour
        public Jour Add(Jour j)
        {
            using (var context = EntityContainer.getInstance())
            {
                Jour jour;
                jour = context.JourSet.Add(j);
                context.SaveChanges();
                return jour;
            }
        }
		// Utiliser pour get un jour
        public Jour Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.JourSet.First(x => x.Id == id);
            }
        }
		// Utiliser pour update un jour
        public void Update(Jour j)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(j).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }
		// Utiliser pour delete un jour
        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Jour jour = context.JourSet.Find(id);
                context.JourSet.Remove(jour);
                context.SaveChanges();
            }
        }
    }
}
