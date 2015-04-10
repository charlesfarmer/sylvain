using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceLogin : Service, IServiceLogin
    {
		public ServiceLogin(): base()
        {
            // constructeur
        }

        public Login Add(Login l)
        {
            using (var context = EntityContainer.getInstance())
            {
                Login login;
                login = context.LoginSet.Add(l);
                context.SaveChanges();
                return login;
            }
        }

        public Login Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                try
                {
                    return context.LoginSet.First(x => x.Id == id);
                }
                catch (InvalidOperationException e)
                {
                    // something like Logger.log(e.StackTrace.ToString())
                    return null;
                }
            }
        }

        public void Update(Login l)
        {
            using (var context = EntityContainer.getInstance())
            {
                context.Entry(l).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                Login login = context.LoginSet.Find(id);
                context.LoginSet.Remove(login);
                context.SaveChanges();
            }
        }

        public bool ValidateAdminLogin(Login l)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.LoginSet.Any(
                    x => x.IsAdmin
                      && l.Code.Equals(x.Code)
                      && l.Mot_de_Passe.Equals(x.Mot_de_Passe)
                );
            }
        }


        public Login FindByCodeAndPass(string code, string pass, bool hasToBeEtudiant)
        {
            using (var context = EntityContainer.getInstance())
            {
                if (hasToBeEtudiant)
                {
                    return context.LoginSet.Include("Etudiant.Coordonnees").FirstOrDefault(x => x.Code == code && x.Mot_de_Passe == pass && x.Etudiant != null);
                }
                else
                {
                    return context.LoginSet.FirstOrDefault(x => x.Code == code && x.Mot_de_Passe == pass);
                }

            }
        }

		// Rechere les Admin. par critere
		public List<Login> FindByCritere(String typeDeRecherche, String texteATrouver)
		{
			using (var context = EntityContainer.getInstance())
			{

				switch (typeDeRecherche)
				{

					case "ID": return context.LoginSet.Where(x => x.Id == Int32.Parse(texteATrouver)).ToList();

					case "Identifiant": return context.LoginSet.Where(x => x.Code.ToLowerInvariant().Contains(texteATrouver.ToLowerInvariant())).ToList();

					default: return new List<Login>();

				}

			}
		}
    }
}
