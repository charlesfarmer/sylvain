using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceSujet : Service, IServiceSujet
    {
		public ServiceSujet(EntityContainer context) : base(context)
        {
            // constructeur
        }

        public Sujet Add(Sujet s)
        {
            Sujet sujet;
                sujet = context.SujetSet.Add(s);
                context.SaveChanges();
                return sujet;
        }

        public Sujet Get(int id)
        {
                return context.SujetSet.First(x => x.Id == id);
        }

        public void Update(Sujet s)
        {
                context.Entry(s).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                Sujet sujet = context.SujetSet.Find(id);
                context.SujetSet.Remove(sujet);
                context.SaveChanges();
        }
    }
}
