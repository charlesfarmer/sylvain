using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceCoursHoraire : Service, IServiceCoursHoraire
    {
		public ServiceCoursHoraire(): base()
        {
            // constructeur
        }
		// Utiliser pour add un CoursHoraire
        public CoursHoraire Add(CoursHoraire c)
        {
            using (var context = EntityContainer.getInstance())
            {
                CoursHoraire coursHoraire;
                coursHoraire = context.CoursHoraireSet.Add(c);
                context.SaveChanges();
                return coursHoraire;
            }
        }
		// Utiliser pour get un CoursHoraire
        public CoursHoraire Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.CoursHoraireSet.First(x => x.Id == id);
            }
        }
		// Utiliser pour update un CoursHoraire
        public void Update(CoursHoraire c)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(c).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }
		// Utiliser pour delete un CoursHoraire
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
