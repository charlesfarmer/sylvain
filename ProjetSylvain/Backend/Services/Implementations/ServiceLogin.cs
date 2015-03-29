using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    class ServiceLogin : Service, IServiceLogin
    {
        public ServiceLogin() : base()
        {
            // constructeur
        }

        public Login Add(Login l)
        {
            Login login;
            using (var context = EntityContainer.getInstance())
            {
                login = context.LoginSet.Add(l);
                context.SaveChanges();
                return login;
            }
        }

        public Login Get(int id)
        {
            using (var context = EntityContainer.getInstance())
            {
                return context.LoginSet.First(x => x.Id == id);
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
    }
}
