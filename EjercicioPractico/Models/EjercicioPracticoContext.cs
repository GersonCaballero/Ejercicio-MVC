using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjercicioPractico.Models
{
    public class EjercicioPracticoContext:DbContext
    {
        public EjercicioPracticoContext()
        {

        }
        public DbSet<Coche> Coches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Alquiler> Alquilers { get; set; }

        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}