using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    class ServiceCoursHoraire : Service, IServiceCoursHoraire
    {
        public ServiceCoursHoraire() : base()
        {
            // constructeur
        }

        public CoursHoraire Add(CoursHoraire c)
        {
            CoursHoraire coursHoraire;
            using (var context = EntityContainer.getInstance())
            {
                coursHoraire = context.CoursHoraireSet.Add(c);
                context.SaveChanges();
                return coursHoraire;
            }
        }

        public CoursHoraire Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.CoursHoraireSet.First(x => x.Id == id);
            }
        }

        public void Update(CoursHoraire c)
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
                CoursHoraire coursHoraire = context.CoursHoraireSet.Find(id);
                context.CoursHoraireSet.Remove(coursHoraire);
                context.SaveChanges();
            }
        }
    }
}
