using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceCours : Service, IServiceCours
    {
        public ServiceCours() : base()
        {
            // constructeur
        }

        public Cours Add(Cours c)
        {
            Cours cours;
            using (var context = EntityContainer.getInstance())
            {
                cours = context.CoursSet.Add(c);
                context.SaveChanges();
                return cours;
            }
        }

        public Cours Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.CoursSet.First(x => x.Id == id);
            }
        }

        public void Update(Cours c)
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
                Cours cours = context.CoursSet.Find(id);
                context.CoursSet.Remove(cours);
                context.SaveChanges();
            }
        }
    }
}
