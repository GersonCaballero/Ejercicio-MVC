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
    }
}