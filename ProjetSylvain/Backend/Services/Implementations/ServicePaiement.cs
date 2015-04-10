using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServicePaiement : Service, IServicePaiement
    {
		public ServicePaiement() : base()
        {
            // constructeur
        }
		// Utiliser pour add un Paiement
        public Paiement Add(Paiement p)
        {
            using (var context = EntityContainer.getInstance())
            {
                Paiement paiement;
                paiement = context.PaiementSet.Add(p);
                context.SaveChanges();
                return paiement;
            }
        }
		// Utiliser pour get un Paiement
        public Paiement Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.PaiementSet.First(x => x.Id == id);
            }
        }
		// Utiliser pour update un Paiement
        public void Update(Paiement p)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(p).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }
		// Utiliser pour delete un Paiement
        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Paiement paiement = context.PaiementSet.Find(id);
                context.PaiementSet.Remove(paiement);
                context.SaveChanges();
            }
        }
    }
}
