using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceInscription : Service, IServiceInscription
    {
        public ServiceInscription() : base()
        {
            // constructeur
        }

        public Inscription Add(Inscription i)
        {
            Inscription inscription;
            using (var context = EntityContainer.getInstance())
            {
                inscription = context.InscriptionSet.Add(i);
                context.SaveChanges();
                return inscription;
            }
        }

        public Inscription Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.InscriptionSet.First(x => x.Id == id);
            }
        }

        public void Update(Inscription i)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(i).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Inscription inscription = context.InscriptionSet.Find(id);
                context.InscriptionSet.Remove(inscription);
                context.SaveChanges();
            }
        }
    }
}
