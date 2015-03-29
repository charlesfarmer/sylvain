using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Backend
{
    public partial class EntityContainer
    {
        public EntityContainer(bool createWithConnectionString)
            : base("name=EntityContainer")
        {
            if (createWithConnectionString)
            {
                this.Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["EntityContainer"].ConnectionString;
            }
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public static EntityContainer getInstance() {
            return new EntityContainer();
        }
    }
}
