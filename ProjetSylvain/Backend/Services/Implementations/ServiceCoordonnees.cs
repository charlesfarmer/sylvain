using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;
using System.Configuration;

namespace Backend.Services.Implementations
{
    public class ServiceCoordonnees : Service, IServiceCoordonnees
    {
        public ServiceCoordonnees() : base()
        {
            // constructeur
        }

        public Coordonnees Add(Coordonnees c)
        {
            using (var context = EntityContainer.getInstance())
            {
                Coordonnees coordonnees;
                coordonnees = context.CoordonneesSet.Add(c);
                context.SaveChanges();
                return coordonnees;
            }
        }

        public Coordonnees Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.CoordonneesSet.First(x => x.Id == id);
            }
        }

        public void Update(Coordonnees c)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(c).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Coordonnees coordonnees = context.CoordonneesSet.Find(id);
                context.CoordonneesSet.Remove(coordonnees);
                context.SaveChanges();
            }
        }
    }
}
