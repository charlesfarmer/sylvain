using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backend.Services.Interfaces;

namespace Backend.Services.Implementations
{
    public class Service : IService
    {
		protected EntityContainer context;

        public Service(EntityContainer Context)
        {
			context = Context;
        }
    }
}
