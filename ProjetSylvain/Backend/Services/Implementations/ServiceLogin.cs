using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class ServiceLogin : Service, IServiceLogin
    {
		public ServiceLogin(EntityContainer context): base(context)
        {
            // constructeur
        }

        public Login Add(Login l)
        {
            Login login;
                login = context.LoginSet.Add(l);
                context.SaveChanges();
                return login;
        }

        public Login Get(int id)
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

        public void Update(Login l)
        {
                context.Entry(l).State = System.Data.EntityState.Modified;
                context.SaveChanges();
        }

        public void Delete(int id)
        {
                Login login = context.LoginSet.Find(id);
                context.LoginSet.Remove(login);
                context.SaveChanges();
        }

        public bool ValidateAdminLogin(Login l)
        {
                return context.LoginSet.Any(
                    x => x.IsAdmin
                      && l.Code.Equals(x.Code)
                      && l.Mot_de_Passe.Equals(x.Mot_de_Passe)
                );
        }
    }
}
