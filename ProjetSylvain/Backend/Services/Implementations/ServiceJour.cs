using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceJour : Service, IServiceJour
    {
		public ServiceJour(EntityContainer context) : base(context)
        {
            // constructeur
        }

        public Jour Add(Jour j)
        {
            Jour jour;
                jour = context.JourSet.Add(j);
                context.SaveChanges();
                return jour;
        }

        public Jour Get(int id)
        {
                return context.JourSet.First(x => x.Id == id);
        }

        public void Update(Jour j)
        {
                context.Entry(j).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                Jour jour = context.JourSet.Find(id);
                context.JourSet.Remove(jour);
                context.SaveChanges();
        }
    }
}
