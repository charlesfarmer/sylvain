using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceCoursHoraire : Service, IServiceCoursHoraire
    {
		public ServiceCoursHoraire(EntityContainer context): base(context)
        {
            // constructeur
        }

        public CoursHoraire Add(CoursHoraire c)
        {
            CoursHoraire coursHoraire;
                coursHoraire = context.CoursHoraireSet.Add(c);
                context.SaveChanges();
                return coursHoraire;
        }

        public CoursHoraire Get(int id)
        {
                return context.CoursHoraireSet.First(x => x.Id == id);
        }

        public void Update(CoursHoraire c)
        {
                context.Entry(c).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                CoursHoraire coursHoraire = context.CoursHoraireSet.Find(id);
                context.CoursHoraireSet.Remove(coursHoraire);
                context.SaveChanges();
        }
    }
}
