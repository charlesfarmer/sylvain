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

        public ProfesseurHoraire Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.ProfesseurHoraireSet.First(x => x.Id == id);
            }
        }

        public void Update(ProfesseurHoraire ph)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(ph).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

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
