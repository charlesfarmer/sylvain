using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    interface IServiceLogin : IService
    {
        Login Get(int id);
        Login Add(Login login);
        void Update(Login login);
        void Delete(Login login);
    }
}
