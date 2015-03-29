using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    class ServicePaiement : Service, IServicePaiement
    {
        public ServicePaiement() : base()
        {
            // constructeur
        }

        public Paiement Add(Paiement p)
        {
            Paiement paiement;
            using (var context = EntityContainer.getInstance())
            {
                paiement = context.PaiementSet.Add(p);
                context.SaveChanges();
                return paiement;
            }
        }

        public Paiement Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.PaiementSet.First(x => x.Id == id);
            }
        }

        public void Update(Paiement p)
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
                Paiement paiement = context.PaiementSet.Find(id);
                context.PaiementSet.Remove(paiement);
                context.SaveChanges();
            }
        }
    }
}
