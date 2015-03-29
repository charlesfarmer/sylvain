﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    interface IServiceJour : IService
    {
        Jour Get(int id);
        Jour Add(Jour jour);
        void Update(Jour jour);
        void Delete(Jour jour);
    }
}
