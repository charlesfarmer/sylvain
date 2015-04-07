using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceCours : Service, IServiceCours
    {
		public ServiceCours(EntityContainer context) : base(context)
        {
            // constructeur
        }

        public Cours Add(Cours c)
        {
            Cours cours;
                cours = context.CoursSet.Add(c);
                context.SaveChanges();
                return cours;
		}

        public Cours Get(int id)
        {
                return context.CoursSet.First(x => x.Id == id);
		}

        public void Update(Cours c)
        {
                context.Entry(c).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                Cours cours = context.CoursSet.Find(id);
                context.CoursSet.Remove(cours);
                context.SaveChanges();
        }
    }
}
