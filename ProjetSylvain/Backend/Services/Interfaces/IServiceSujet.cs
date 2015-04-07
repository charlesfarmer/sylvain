using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    public interface IServiceSujet : IService
    {
        Sujet Get(int id);
        Sujet Add(Sujet sujet);
        void Update(Sujet sujet);
        void Delete(int id);
    }
}
