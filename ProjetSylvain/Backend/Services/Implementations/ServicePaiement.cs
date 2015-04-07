using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServicePaiement : Service, IServicePaiement
    {
		public ServicePaiement(EntityContainer context) : base(context)
        {
            // constructeur
        }

        public Paiement Add(Paiement p)
        {
            Paiement paiement;
                paiement = context.PaiementSet.Add(p);
                context.SaveChanges();
                return paiement;
        }

        public Paiement Get(int id)
        {
                return context.PaiementSet.First(x => x.Id == id);
        }

        public void Update(Paiement p)
        {
                context.Entry(p).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                Paiement paiement = context.PaiementSet.Find(id);
                context.PaiementSet.Remove(paiement);
                context.SaveChanges();
        }
    }
}
