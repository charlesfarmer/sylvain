using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceInscription : Service, IServiceInscription
    {
		public ServiceInscription(EntityContainer context) : base(context)
        {
            // constructeur
        }

        public Inscription Add(Inscription i)
        {
            Inscription inscription;
                inscription = context.InscriptionSet.Add(i);
                context.SaveChanges();
                return inscription;
        }

        public Inscription Get(int id)
        {
                return context.InscriptionSet.First(x => x.Id == id);
        }

        public void Update(Inscription i)
        {
                context.Entry(i).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                Inscription inscription = context.InscriptionSet.Find(id);
                context.InscriptionSet.Remove(inscription);
                context.SaveChanges();
        }
    }
}
