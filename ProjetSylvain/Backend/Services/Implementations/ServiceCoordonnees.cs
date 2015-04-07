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
        public ServiceCoordonnees(EntityContainer context) : base(context)
        {
            // constructeur
        }

        public Coordonnees Add(Coordonnees c)
        {
            Coordonnees coordonnees;
                coordonnees = context.CoordonneesSet.Add(c);
                context.SaveChanges();
                return coordonnees;
        }

        public Coordonnees Get(int id)
        {
                return context.CoordonneesSet.First(x => x.Id == id);
        }

        public void Update(Coordonnees c)
        {
                context.Entry(c).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                Coordonnees coordonnees = context.CoordonneesSet.Find(id);
                context.CoordonneesSet.Remove(coordonnees);
                context.SaveChanges();
        }
    }
}
