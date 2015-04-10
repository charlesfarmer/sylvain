using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
	// Interface pour IServiceJour
    public interface IServiceJour : IService
    {
        Jour Get(int id);
        Jour Add(Jour jour);
        void Update(Jour jour);
        void Delete(int id);
    }
}
