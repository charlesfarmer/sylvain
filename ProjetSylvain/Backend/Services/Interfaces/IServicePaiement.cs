using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
	// Interface pour IServicePaiement
    public interface IServicePaiement : IService
    {
        Paiement Get(int id);
        Paiement Add(Paiement paiement);
        void Update(Paiement paiement);
        void Delete(int id);
        Paiement AddNewPaiement(decimal montant, Boolean rembourse, DateTime timeStamp, int inscriptionId);
    }
}
