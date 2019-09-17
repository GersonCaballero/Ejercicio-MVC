using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjercicioPractico.Models
{
    public class NewAlquilerViewModel
    {
        public IEnumerable<User> Users { get; set; }

        public IEnumerable<Coche> Coches { get; set; }
        public Alquiler Alquiler { get; set; }
    }
}