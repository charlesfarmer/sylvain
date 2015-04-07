using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceProfesseurHoraire : Service, IServiceProfesseurHoraire
    {
        public ServiceProfesseurHoraire(EntityContainer context) : base(context){
            // constructeur
        }

        public ProfesseurHoraire Add(ProfesseurHoraire ph)
        {
            ProfesseurHoraire professeurHoraire;
                professeurHoraire = context.ProfesseurHoraireSet.Add(ph);
                context.SaveChanges();
                return professeurHoraire;
        }

        public ProfesseurHoraire Get(int id)
        {
                return context.ProfesseurHoraireSet.First(x => x.Id == id);
        }

        public void Update(ProfesseurHoraire ph)
        {
                context.Entry(ph).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                ProfesseurHoraire professeurHoraire = context.ProfesseurHoraireSet.Find(id);
                context.ProfesseurHoraireSet.Remove(professeurHoraire);
                context.SaveChanges();
        }
    }
}
