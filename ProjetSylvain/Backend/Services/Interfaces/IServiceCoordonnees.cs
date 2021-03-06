﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
	// Interface pour IServiceCoordonnees
    public interface IServiceCoordonnees : IService
    {
        Coordonnees Get(int id);
        Coordonnees Add(Coordonnees coordonnees);
        void Update(Coordonnees coordonnees);
        void Delete(int id);
    }
}
