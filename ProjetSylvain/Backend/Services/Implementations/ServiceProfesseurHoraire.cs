using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceProfesseurHoraire : Service, IServiceProfesseurHoraire
    {
        public ServiceProfesseurHoraire() : base(){
            // constructeur
        }
		// Utiliser pour add un ProfesseurHoraire
        public ProfesseurHoraire Add(ProfesseurHoraire ph)
        {
            using (var context = EntityContainer.getInstance())
            {
                ProfesseurHoraire professeurHoraire;
                professeurHoraire = context.ProfesseurHoraireSet.Add(ph);
                context.SaveChanges();
                return professeurHoraire;
            }
        }
		// Utiliser pour get un ProfesseurHoraire
        public ProfesseurHoraire Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.ProfesseurHoraireSet.First(x => x.Id == id);
            }
        }
		// Utiliser pour update un ProfesseurHoraire
        public void Update(ProfesseurHoraire ph)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(ph).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }
		// Utiliser pour delete un ProfesseurHoraire
        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                ProfesseurHoraire professeurHoraire = context.ProfesseurHoraireSet.Find(id);
                context.ProfesseurHoraireSet.Remove(professeurHoraire);
                context.SaveChanges();
            }
        }
    }
}
