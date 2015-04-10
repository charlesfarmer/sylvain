using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
	// Interface pour IServiceInscription
    public interface IServiceInscription : IService
    {
        Inscription Get(int id);
        Inscription Add(Inscription inscription);
        void Update(Inscription inscription);
        void Delete(int id);
    }
}
