using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    interface IServicePaiement : IService
    {
        Paiement Get(int id);
        Paiement Add(Paiement paiement);
        void Update(Paiement paiement);
        void Delete(Paiement paiement);
    }
}
